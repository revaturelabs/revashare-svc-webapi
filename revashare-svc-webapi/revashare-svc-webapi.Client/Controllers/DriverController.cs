using revashare_svc_webapi.Client.Models.OwinModels;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace revashare_svc_webapi.Client.Controllers
{

    [Authorize(Roles = "Driver")]
    [RoutePrefix("api/driver")]
    public class DriverController : ApiController
    {
        private readonly IDriverRepository repo;
        private UserFactory userFactory;

        public DriverController(IDriverRepository repo)
        {
            this.repo = repo;
            this.userFactory = UserFactory.getFactory();
        }

        /// <summary>
        /// Allows driver to view personal vehicle info
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("viewvehicle")]
        public HttpResponseMessage ViewVehicleInfo([FromUri]string driver)
        {

            var user = this.userFactory.getUser(Request.GetOwinContext());

            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, user.ViewVehicleInfo());
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        [Route("addvehicle")]
        public HttpResponseMessage AddVehicle([FromBody] VehicleDTO vehicle)
        {

            var user = this.userFactory.getUser(Request.GetOwinContext());

            try
            {
                bool success = user.AddVehicle(vehicle);

                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, success);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        /// <summary>
        /// Allows driver to update vehicle info
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("updatevehicle")]
        public HttpResponseMessage UpdateVehicleInfo([FromBody]VehicleDTO vehicle)
        {

            var user = this.userFactory.getUser(Request.GetOwinContext());

            try
            {
                bool success = user.UpdateVehicleInfo(vehicle);

                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, success);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        /// <summary>
        /// Allows driver to report rider
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("reportrider")]
        public HttpResponseMessage ReportRider([FromBody]FlagDTO flag)
        {

            var user = this.userFactory.getUser(Request.GetOwinContext());

            try
            {
                bool success = user.ReportRider(flag);

                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, success);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        /// <summary>
        /// Allows driver to change availability of ride
        /// </summary>
        /// <param name="ride"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("setavailability")]
        public HttpResponseMessage SetAvailability([FromBody]RideDTO ride)
        {

            var user = this.userFactory.getUser(Request.GetOwinContext());

            try
            {
                bool success = user.SetAvailability(ride);

                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, success);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }


        /// <summary>
        /// Allows driver to schedule ride
        /// </summary>
        /// <param name="ride"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("scheduleride")]
        public HttpResponseMessage ScheduleRide([FromBody]RideDTO ride)
        {

            var user = this.userFactory.getUser(Request.GetOwinContext());

            try
            {
                bool success = user.ScheduleRide(ride);

                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, success);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        [Route("getRide")]
        public HttpResponseMessage GetDriverRide([FromBody]RideDTO ride)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, this.repo.getSingleRide(ride));
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        /// <summary>
        /// Allows driver to cancel ride
        /// </summary>
        /// <param name="ride"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("cancelride")]
        public HttpResponseMessage CancelRide([FromBody]RideDTO ride)
        {

            var user = this.userFactory.getUser(Request.GetOwinContext());

            try
            {
                bool success = user.CancelRide(ride);

                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, success);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        /// <summary>
        /// Allows driver to view passenger list for ride (accepted/not accepted)
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("viewpassengers")]
        public HttpResponseMessage ViewPassengers(RideDTO ride)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, this.repo.ViewPassengers(ride));
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        /// <summary>
        /// Allows driver to accept passenger
        /// </summary>
        /// <param name="rider"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("acceptpassenger")]
        public HttpResponseMessage AcceptPassenger([FromBody]RideRiderDTO rider)
        {

            var user = this.userFactory.getUser(Request.GetOwinContext());

            try
            {
                bool success = user.AcceptPassenger(rider);

                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, success);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
