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

        #region Admin CRUD
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

        #region Driver CRUD
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

        #region Rider CRUD
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

        #region User Approval
        [HttpPost]
        [Route("approve-user")]
        public HttpResponseMessage ApproveUser([FromBody] UserDTO user)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.ApproveUser(user));
        }

        [HttpGet]
        [Route("get-pending-riders")]
        public HttpResponseMessage GetPendingRiders()
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.GetPendingRiders(), "application/json");
        }

        [HttpGet]
        [Route("get-pending-drivers")]
        public HttpResponseMessage GetPendingDrivers()
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.GetPendingDrivers(), "application/json");
        }

        [HttpGet]
        [Route("get-pending-admins")]
        public HttpResponseMessage GetPendingAdmins()
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.GetPendingAdmins(), "application/json");
        }
        #endregion

        #region User Reporting
        [HttpGet]
        [Route("get-user-reports")]
        public HttpResponseMessage UserReports()
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.GetUserReports(), "application/json");
        }

        [HttpPost]
        [Route("remove-report")]
        public HttpResponseMessage RemoveReport([FromBody] FlagDTO report)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.RemoveReport(report));
        }

        [HttpPost]
        [Route("remove-driver-privileges")]
        public HttpResponseMessage RemoveDriverPrivileges([FromBody] FlagDTO report)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.RemoveDriverPrivileges(report));
        }
        #endregion
    }
}