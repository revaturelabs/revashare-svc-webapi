﻿using revashare_svc_webapi.Logic.Interfaces;
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

    [HttpPost]
    [Route("report")]
    public HttpResponseMessage Post([FromBody]FlagDTO flag) {
      try {
        return Request.CreateResponse(HttpStatusCode.OK, this.repo.ReportRider(flag));
      }
      catch (Exception) {
        return Request.CreateResponse(HttpStatusCode.BadRequest);
      }
    }

    [HttpPut]
    [Route("update/vehicle")]
    public HttpResponseMessage Put([FromBody]VehicleDTO vehicle) {
      try {
        return Request.CreateResponse(HttpStatusCode.OK, this.repo.UpdateVehicleInfo(vehicle));
      }
      catch (Exception) {
        return Request.CreateResponse(HttpStatusCode.BadRequest);
      }
    }

    [HttpPost]
    [Route("schedule")]
    public HttpResponseMessage ScheduleRide([FromBody]RideDTO ride) {
      try {
        return Request.CreateResponse(HttpStatusCode.OK, this.repo.ScheduleRide(ride));
      }
      catch (Exception) {
        return Request.CreateResponse(HttpStatusCode.BadRequest);
      }
    }

    [HttpPost]
    [Route("cancel")]
    public HttpResponseMessage CancelRide([FromBody]RideDTO ride) {
      try {
        return Request.CreateResponse(HttpStatusCode.OK, this.repo.CancelRide(ride));
      }
      catch (Exception) {
        return Request.CreateResponse(HttpStatusCode.BadRequest);
      }
    }

    [HttpPost]
    [Route("addcar")]
    public HttpResponseMessage AddCar([FromBody]VehicleDTO vehicle) {
      try {
        return Request.CreateResponse(HttpStatusCode.OK, this.repo.AddVehicle(vehicle));
      }
      catch (Exception) {
        return Request.CreateResponse(HttpStatusCode.BadRequest);
      }
    }
    // DELETE: api/Driver/5
    public void Delete(int id) {
    }

    #region Driver CRUD Methods
        [HttpPost]
        [Route("add-driver")]
        public HttpResponseMessage AddDriver([FromBody] UserDTO driver)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.repo.InsertDriver(driver));
        }

        [HttpGet]
        [Route("get-drivers")]
        public HttpResponseMessage GetDrivers()
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.repo.RequestDrivers(), "application/json");
        }

        [HttpPut]
        [Route("update-driver")]
        public HttpResponseMessage UpdateDriver([FromBody] UserDTO driver)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.repo.ModifyDriver(driver));
        }

        [HttpPost]
        [Route("remove-driver")]
        public HttpResponseMessage RemoveDriver([FromBody] UserDTO driver)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.repo.DeleteDriver(driver));
        }
        #endregion

    }
}
