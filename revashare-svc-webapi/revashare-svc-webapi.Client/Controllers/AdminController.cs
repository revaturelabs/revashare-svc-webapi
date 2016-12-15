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

        #region Admin CRUD Methods
        [HttpPost]
        [Route("add-admin")]
        public HttpResponseMessage AddAdmin([FromBody] UserDTO admin)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.InsertAdmin(admin));
        }

        [HttpGet]
        [Route("get-admins")]
        public HttpResponseMessage GetAdmins()
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.RequestAdmins(), "application/json");
        }

        [HttpPut]
        [Route("update-admin")]
        public HttpResponseMessage UpdateAdmin([FromBody] UserDTO admin)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.ModifyAdmin(admin));
        }

        [HttpPut]
        [Route("remove-admin")]
        public HttpResponseMessage RemoveAdmin([FromBody] UserDTO admin)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.DeleteAdmin(admin));
        }
        #endregion

        #region Driver CRUD Methods
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

        [HttpPut]
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

        #region Rider CRUD Methods
        [HttpPost]
        [Route("add-rider")]
        public HttpResponseMessage AddRider([FromBody] UserDTO rider)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.InsertRider(rider));
        }

        [HttpGet]
        [Route("get-riders")]
        public HttpResponseMessage GetRiders()
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.RequestRiders(), "application/json");
        }

        [HttpPut]
        [Route("update-rider")]
        public HttpResponseMessage UpdateRider([FromBody] UserDTO rider)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.ModifyRider(rider));
        }

        [HttpPost]
        [Route("remove-rider")]
        public HttpResponseMessage RemoveRider([FromBody] UserDTO rider)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.DeleteRider(rider));
        }
        #endregion
    }
}