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
        public IHttpActionResult signup([FromUri] RevaShareServiceReference.UserDAO userModel, string password)
        {

            bool success = client.RegisterUser(userModel, userModel.UserName, password);

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
            
            // should get from login
            var user = client.Login(model.userName, model.password);

            if (user == null)
            {
                // handle case where user could not login
                return StatusCode(HttpStatusCode.BadRequest);
            }

            Claim[] claims = new Claim[]
            {
                new Claim(ClaimTypes.Role, "user"),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Email, user.Email),
            };

            ClaimsIdentity identity = new ClaimsIdentity(claims, "ApplicationCookie");

            // Add roles into claims
            //List<Logic.RevaShareServiceReference.RoleDAO> roleList = new List<Logic.RevaShareServiceReference.RoleDAO>(user.Roles);
            //var roleClaims = roleList.ConvertAll(x => new Claim(ClaimTypes.Role, x.Type));
            //roleClaims.Add(new Claim(ClaimTypes.Role, "user"));
            //identity.AddClaims(roleClaims);
            
            var context = Request.GetOwinContext();
            var authManager = context.Authentication;
            authManager.SignIn(identity);
            //authManager.SignIn(new AuthenticationProperties { IsPersistent = true }, identity);
            
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

