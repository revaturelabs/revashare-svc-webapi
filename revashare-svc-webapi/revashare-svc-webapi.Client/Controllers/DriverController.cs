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

    // GET: api/Driver
    public IEnumerable<string> Get() {
      return new string[] { "value1", "value2" };
    }

    // GET: api/Driver/5
    public string Get(int id) {
      return "value";
    }

    // POST: api/Driver
    public void Post([FromBody]string value) {
    }

    [Route("update/vehicle")]
    public HttpResponseMessage Put([FromBody]VehicleDTO vehicle) {
      try {
        return Request.CreateResponse(HttpStatusCode.OK, this.repo.UpdateVehicleInfo(vehicle));
      }
      catch (Exception) {
        return Request.CreateResponse(HttpStatusCode.BadRequest);
      }
    }

    // DELETE: api/Driver/5
    public void Delete(int id) {
    }
  }
}
