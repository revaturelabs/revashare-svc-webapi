using revashare_svc_webapi.Client.Models.OwinModels;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace revashare_svc_webapi.Client.Controllers
{

    [Authorize(Roles = "Rider,RequestDriver,Driver,Admin")]
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        private IUser userLogic;
        private UserFactory userFactory;

        public UserController(IUser UL)
        {
            userLogic = UL;
            this.userFactory = UserFactory.getFactory();
        }
        
        [HttpGet]
        [Authorize(Roles = "Unassigned,Rider,RequestDriver,Driver,Admin")]
        [Route("profile")]
        public IHttpActionResult profile()
        {
            UserFactory userFactory = UserFactory.getFactory();
            var owinUser = userFactory.getUser(Request.GetOwinContext());

            if (owinUser == null)
            {
                return StatusCode(HttpStatusCode.Unauthorized);
            }

            return Json(owinUser.getProfile());
        }


        [HttpPost]
        [Authorize(Roles = "Unassigned,Rider,RequestDriver,Driver,Admin")]
        [Route("updateProfile")]
        public IHttpActionResult updateProfile(UserDTO profile)
        {
            UserFactory userFactory= UserFactory.getFactory();
            var user = userFactory.getUser(Request.GetOwinContext());

            if (user.updateProfile(profile))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }


        [HttpGet]
        [Route("get-user")]
        public HttpResponseMessage GetUser([FromUri] string username)
        {
            return Request.CreateResponse(HttpStatusCode.OK, userLogic.GetUser(username), "application/json");
        }

        [HttpGet]
        [Route("get-users")]
        public HttpResponseMessage GetUsers()
        {
            return Request.CreateResponse(HttpStatusCode.OK, userLogic.GetUsers(), "application/json");
        }

        [HttpGet]
        [Route("get-apartment")]
        public HttpResponseMessage GetApartment([FromUri] string name)
        {
            return Request.CreateResponse(HttpStatusCode.OK, userLogic.GetApartment(name), "application/json");
        }

        [HttpGet]
        [Route("get-apartments")]
        public HttpResponseMessage GetApartments()
        {
            return Request.CreateResponse(HttpStatusCode.OK, userLogic.GetApartments(), "application/json");
        }

        [HttpGet]
        [Route("get-available-rides")]
        public IHttpActionResult getAvailableRides()
        {
            var user = userFactory.getUser(Request.GetOwinContext());

            try
            {
                return Json(user.getAvailableRides());
            }
            catch (MissingPermission)
            {
                return Unauthorized();
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("get-scheduled-rides")]
        public IHttpActionResult getScheduledRides()
        {
            var user = userFactory.getUser(Request.GetOwinContext());

            try
            {
                return Json(user.getScheduledRides());
            }
            catch (MissingPermission)
            {
                return Unauthorized();
            }
            

        }

        [HttpGet]
        [Route("get-rides-by-apartment")]
        public HttpResponseMessage GetRidesByApartment([FromUri] string name)
        {
            return Request.CreateResponse(HttpStatusCode.OK, userLogic.GetRidesByApartment(name), "application/json");
        }

        [HttpGet]
        [Route("get-morning-rides-by-apartment")]
        public HttpResponseMessage GetMorningRidesByApartment([FromUri] string name)
        {
            return Request.CreateResponse(HttpStatusCode.OK, userLogic.GetMorningRidesByApartment(name), "application/json");
        }

        [HttpGet]
        [Route("get-evening-rides-by-apartment")]
        public HttpResponseMessage GetEveningRidesByApartment([FromUri] string name)
        {
            return Request.CreateResponse(HttpStatusCode.OK, userLogic.GetEveningRidesByApartment(name), "application/json");
        }
    }
}
