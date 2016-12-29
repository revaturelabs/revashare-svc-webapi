using revashare_svc_webapi.Client.Models.OwinModels;
using revashare_svc_webapi.Logic;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RiderLogic;
using revashare_svc_webapi.Logic.ServiceClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace revashare_svc_webapi.Client.Controllers
{
    [RoutePrefix("api/rider")]
    public class RideController : ApiController
    {

        public RideController()
        {

        }


        [Authorize(Roles = "Rider,RequestDriver,Driver")]
        [HttpGet]
        [Route("rides")]
        public IHttpActionResult getRides()
        {

            var user = UserFactory.getFactory().getUser(Request.GetOwinContext());

            if (user == null)
            {
                return Unauthorized();
            }

            try
            {
                List<RideDTO> rides = user.getRides();
                return Json(rides);
            }
            catch (MissingPermission err)
            {
                return Unauthorized();
            }

        }


        [Authorize(Roles = "Rider,RequestDriver,Driver")]
        [HttpPost]
        [Route("bookRide")]
        public IHttpActionResult bookRide(RideDTO ride)
        {

            var user = UserFactory.getFactory().getUser(Request.GetOwinContext());

            if (user == null)
            {
                return Unauthorized();
            }

            try
            {
                bool success = user.bookRide(ride);
                if (success)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (MissingPermission err)
            {
                return Unauthorized();
            }
        }


        [Authorize(Roles = "Rider,RequestDriver,Driver")]
        [HttpPost]
        [Route("unBookRide")]
        public IHttpActionResult unBookRide(RideDTO ride)
        {

            var user = UserFactory.getFactory().getUser(Request.GetOwinContext());

            if (user == null)
            {
                return Unauthorized();
            }

            try
            {
                bool success = user.unBookRide(ride);
                if (success)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (MissingPermission err)
            {
                return Unauthorized();
            }
        }


        [Authorize(Roles = "Rider,RequestDriver,Driver")]
        [HttpPost]
        [Route("fileComplaint")]
        public IHttpActionResult fileComplaintAboutDriver(FlagDTO flag)
        {
            var user = UserFactory.getFactory().getUser(Request.GetOwinContext());

            if (user == null)
            {
                return Unauthorized();
            }

            try
            {
                bool success = user.fileComplaintAboutDriver(flag);
                if (success)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (MissingPermission err)
            {
                return Unauthorized();
            }
        }


        [Authorize(Roles = "Rider,RequestDriver,Driver")]
        [HttpPost]
        [Route("driverUpgrade")]
        public IHttpActionResult driverUpgrade(VehicleDTO car)
        {

            var user = UserFactory.getFactory().getUser(Request.GetOwinContext());

            bool success = user.requestToBeDriver(car);

            if (success)
            {
                return Ok();
            }
            else
            {
                return StatusCode(HttpStatusCode.BadRequest);
            }

        }


    }
}