using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace revashare_svc_webapi.Client.Controllers {
  [RoutePrefix("rider")]
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
  }
}
