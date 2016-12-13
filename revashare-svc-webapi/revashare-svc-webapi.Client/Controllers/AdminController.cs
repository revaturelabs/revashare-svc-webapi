using revashare_svc_webapi.Logic;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using revashare_svc_webapi.Logic.Interfaces;

namespace revashare_svc_webapi.Client.Controllers
{
    [RoutePrefix("api/admin")]
    public class AdminController : ApiController
    {
        private readonly IAdminLogic Repo;

        public AdminController( IAdminLogic repo)
        {
            this.Repo = repo;
        }

        [HttpGet]
        public void Get()
        {

        }

        [HttpPost]
        public void Post()
        {

        }

        [HttpPost]
        [Route("add-driver")]
        public HttpResponseMessage AddDriver([FromBody] DriverDTO driverSent)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.InsertDriver(driverSent));
        }

    }
}