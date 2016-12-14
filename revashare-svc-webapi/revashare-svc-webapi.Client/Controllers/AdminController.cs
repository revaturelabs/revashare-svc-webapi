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

        public AdminController(IAdminLogic repo)
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

        #region Driver Related Methods
        [HttpPost]
        [Route("add-driver")]
        public HttpResponseMessage AddDriver([FromBody] UserDTO driver)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.InsertDriver(driver));
        }

        [HttpGet]
        [Route("get-drivers")]
        public HttpResponseMessage GetDrivers()
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.RequestDrivers(), "application/json");
        }

        [HttpPost]
        [Route("update-driver")]
        public HttpResponseMessage UpdateDriver([FromBody] UserDTO driver)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.ModifyDriver(driver));
        }

        [HttpPost]
        [Route("remove-driver")]
        public HttpResponseMessage RemoveDriver([FromBody] UserDTO driver)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.DeleteDriver(driver));
        }
        #endregion

        #region Rider Related Methods
        [HttpPost]
        [Route("add-rider")]
        public HttpResponseMessage AddRider([FromBody] UserDTO newRider)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.InsertRider(newRider));
        }
        #endregion

    }
}