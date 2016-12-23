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
using revashare_svc_webapi.Logic.UserLogic;
using revashare_svc_webapi.Logic.ServiceClient;

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
        public IHttpActionResult signup([FromBody] ViewModels.Account.SignupVM vm)
        {

            if (! vm.isValid())
            {
                return StatusCode(HttpStatusCode.BadRequest);
            }

            bool success = new UserLogic(new ServiceClient()).registerUser(vm.user, vm.password);

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

            return Ok();
        }


        [HttpPost]
        [Route("login")]
        public IHttpActionResult login([FromBody] ViewModels.Account.LoginVM vm)
        {

            var user = new UserLogic(new ServiceClient()).login(vm.userName, vm.password);

            if (user == null)
            {
                return StatusCode(HttpStatusCode.BadRequest);
            }

            if (userSessionExists())
            {
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

            if (! userSessionExists())
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            authManager.SignOut("ApplicationCookie");

            return Ok();
        }


        [Authorize(Roles = "user")]
        [HttpGet]
        [Route("profile")]
        public UserDTO profile()
        {

            var user = userFactory.getUser(Request.GetOwinContext());
            UserDTO userData = user.getProfile();

            return userData;

        }


        #region helpers
        private bool userSessionExists()
        {
            var owinUser = userFactory.getUser(Request.GetOwinContext());
            return owinUser != null;
        }
        #endregion

    }



}

