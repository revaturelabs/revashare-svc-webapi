using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace revashare_svc_webapi.Client.Controllers {
  [RoutePrefix("driver")]
  public class DriverController : ApiController {
    private readonly IDriverRepository repo;

    public DriverController(IDriverRepository repo) {
      this.repo = repo;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="vehicle"></param>
    /// <returns></returns>
    [HttpPut]
    [Route("updatevehicle")]
    public HttpResponseMessage UpdateVehicleInfo([FromBody]VehicleDTO vehicle) {
      try {
        return Request.CreateResponse(HttpStatusCode.OK, this.repo.UpdateVehicleInfo(vehicle));
      }
      catch (Exception) {
        return Request.CreateResponse(HttpStatusCode.BadRequest);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="flag"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("reportrider")]
    public HttpResponseMessage ReportRider([FromBody]FlagDTO flag) {
      try {
        return Request.CreateResponse(HttpStatusCode.OK, this.repo.ReportRider(flag));
      }
      catch (Exception) {
        return Request.CreateResponse(HttpStatusCode.BadRequest);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ride"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("setavailability")]
    public HttpResponseMessage SetAvailability([FromBody]RideDTO ride) {
      try {
        return Request.CreateResponse(HttpStatusCode.OK, this.repo.SetAvailability(ride));
      }
      catch (Exception) {
        return Request.CreateResponse(HttpStatusCode.BadRequest);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="driver"></param>
    /// <returns></returns>
    [HttpPut]
    [Route("updatedriverprofile")]
    public HttpResponseMessage UpdateDriverProfile([FromBody] UserDTO driver) {
      try {
        return Request.CreateResponse(HttpStatusCode.OK, this.repo.UpdateDriverProfile(driver));
      }
      catch (Exception) {
        return Request.CreateResponse(HttpStatusCode.BadRequest);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ride"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("scheduleride")]
    public HttpResponseMessage ScheduleRide([FromBody]RideDTO ride) {
      try {
        return Request.CreateResponse(HttpStatusCode.OK, this.repo.ScheduleRide(ride));
      }
      catch (Exception) {
        return Request.CreateResponse(HttpStatusCode.BadRequest);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ride"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("cancelride")]
    public HttpResponseMessage CancelRide([FromBody]RideDTO ride) {
      try {
        return Request.CreateResponse(HttpStatusCode.OK, this.repo.CancelRide(ride));
      }
      catch (Exception) {
        return Request.CreateResponse(HttpStatusCode.BadRequest);
      }
    }

    [HttpGet]
    [Route("viewpassengers")]
    public HttpResponseMessage ViewPassengers() {
      try {
        return Request.CreateResponse(HttpStatusCode.OK, this.repo.ViewPassengers());
      }
      catch (Exception) {
        return Request.CreateResponse(HttpStatusCode.BadRequest);
      }
    }

    [HttpPost]
    [Route("acceptpassenger")]
    public HttpResponseMessage AcceptPassenger([FromBody]SeatDTO rider) {
      try {
        return Request.CreateResponse(HttpStatusCode.OK, this.repo.AcceptPassenger(rider));
      }
      catch (Exception) {
        return Request.CreateResponse(HttpStatusCode.BadRequest);
      }
    }
  }
}
