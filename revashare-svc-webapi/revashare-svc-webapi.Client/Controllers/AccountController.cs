using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Web;
using System.Web.Http;
using Microsoft.Owin.Security;
using revashare_svc_webapi.Client.Models;
using System.Net;
//using Microsoft.AspNet.Identity;
using System.Threading;
using System.Linq;
using System.Web.Http.Cors;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using revashare_svc_webapi.Logic.Models;
using Newtonsoft.Json;
using revashare_svc_webapi.Logic.Mappers;

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


        //[AllowAnonymous]
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


        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public IHttpActionResult login([FromUri] loginModel model)
        {
            
            // get user from login
            var user = client.Login(model.userName, model.password);

            if (user == null)
            {
                // handle case where user could not login
                return StatusCode(HttpStatusCode.BadRequest);
            }

            UserDTO userDTO = UserMapper.mapToUserDTO(user);
            string userJson = JsonConvert.SerializeObject(userDTO);

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


        [Authorize(Roles = "user")]
        [HttpGet]
        [Route("logout")]
        public IHttpActionResult logout()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
            return Ok();
        }


    }



}

