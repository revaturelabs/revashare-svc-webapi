using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Web;
using System.Web.Http;
using revashare_svc_webapi.Client.Models;
using System.Net;
using System.Threading;
using System.Linq;
using revashare_svc_webapi.Logic.Models;
using Newtonsoft.Json;
using revashare_svc_webapi.Logic.Mappers;
using revashare_svc_webapi.Logic;

namespace revashare_svc_webapi.Client.Controllers
{

    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {

        private RevaShareServiceReference.RevaShareDataServiceClient client;
        private Models.OwinModels.UserFactory userFactory;

        public AccountController()
        {
            this.client = new RevaShareServiceReference.RevaShareDataServiceClient();
            this.userFactory = Models.OwinModels.UserFactory.getFactory();
        }


        [HttpPost]
        [Route("signup")]
        public IHttpActionResult signup([FromUri] UserDTO userModel, string password)
        {

            bool success = client.RegisterUser(UserMapper.mapToUserDAO(userModel), userModel.UserName, password);

            if (success)
            {
                return Ok();
            }
            else
            {
                return StatusCode(HttpStatusCode.BadRequest);
            }

        }


        [HttpGet]
        [Route("test")]
        public IHttpActionResult test()
        {

            Models.OwinModels.UserFactory userFactory = Models.OwinModels.UserFactory.getFactory();
            var owinUser = userFactory.getUser(Request.GetOwinContext());


            var prinicpal = (ClaimsPrincipal)Thread.CurrentPrincipal;
            var role = prinicpal.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value).SingleOrDefault();

            var identity = (ClaimsIdentity)User.Identity;
            IEnumerable<Claim> claims = identity.Claims;
            
            var my_identity = this.User.Identity as ClaimsIdentity;
            Claim firstRole = my_identity.FindFirst(ClaimTypes.Role);
            IEnumerable<Claim> role_claim = my_identity.FindAll(ClaimTypes.Role);
            IEnumerable<Claim> name_claim = my_identity.FindAll(ClaimTypes.Name);
            IEnumerable<Claim> email_claim = my_identity.FindAll(ClaimTypes.Email);

            return Ok();
        }


        [HttpPost]
        [Route("login")]
        public IHttpActionResult login([FromUri] loginModel model)
        {

            // get user from login
            var user = UserLogic.getInstance().login(model.userName, model.password);

            if (user == null)
            {
                // handle case where user could not login
                return StatusCode(HttpStatusCode.BadRequest);
            }

            if (userSessionExists())
            {
                // user is already logged in
                return StatusCode(HttpStatusCode.BadRequest);
            }

            string userJson = JsonConvert.SerializeObject(user);

            Claim[] claims = new Claim[]
            {
                new Claim(ClaimTypes.Role, "user"),
                new Claim(ClaimTypes.UserData, userJson)
            };

            ClaimsIdentity identity = new ClaimsIdentity(claims, "ApplicationCookie");
            identity.AddClaims(claims);
            
            var context = Request.GetOwinContext();
            var authManager = context.Authentication;
            authManager.SignIn(identity);
            
            return Ok();

        }


        [HttpPost]
        [Route("logout")]
        public IHttpActionResult logout()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            if (userSessionExists())
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            authManager.SignOut("ApplicationCookie");
            return Ok();
        }


        private bool userSessionExists()
        {
            var owinUser = userFactory.getUser(Request.GetOwinContext());
            return owinUser != null;
        }


        [HttpGet]
        [Route("profile")]
        public UserDTO profile()
        {

            var user = userFactory.getUser(Request.GetOwinContext());
            UserDTO userData = user.getUserDetails();

            return userData;

        }

    }



}

