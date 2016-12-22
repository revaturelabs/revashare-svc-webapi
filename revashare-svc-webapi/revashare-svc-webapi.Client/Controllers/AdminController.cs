using revashare_svc_webapi.Logic;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.AdminLogic;
using revashare_svc_webapi.Logic.ServiceClient;

namespace revashare_svc_webapi.Client.Controllers
{
    [RoutePrefix("api/admin")]
    public class AdminController : ApiController
    {
        private IAdmin adminLogic;

        public AdminController(IAdmin AL)
        {
            adminLogic = AL;
        }

        #region Admin CRUD
        [HttpPost]
        [Route("add-admin")]
        public HttpResponseMessage AddAdmin([FromBody] UserDTO admin, string password)
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.InsertAdmin(admin, password));
        }

        [HttpGet]
        [Route("get-admin")]
        public HttpResponseMessage GetAdmin([FromUri] string username)
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.RequestAdmin(username), "application/json");
        }

        [HttpGet]
        [Route("get-admins")]
        public HttpResponseMessage GetAdmins()
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.RequestAdmins(), "application/json");
        }

        [HttpPut]
        [Route("update-admin")]
        public HttpResponseMessage UpdateAdmin([FromBody] UserDTO admin)
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.ModifyAdmin(admin));
        }

        [HttpPut]
        [Route("remove-admin")]
        public HttpResponseMessage RemoveAdmin([FromBody] UserDTO admin)
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.DeleteAdmin(admin.UserName));
        }
        #endregion

        #region Driver CRUD
        [HttpGet]
        [Route("get-driver")]
        public HttpResponseMessage GetDriver([FromUri] string username)
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.RequestDriver(username), "application/json");
        }

        [HttpGet]
        [Route("get-drivers")]
        public HttpResponseMessage GetDrivers()
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.RequestDrivers(), "application/json");
        }

        [HttpPut]
        [Route("update-driver")]
        public HttpResponseMessage UpdateDriver([FromBody] UserDTO driver)
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.ModifyDriver(driver));
        }

        [HttpPost]
        [Route("remove-driver")]
        public HttpResponseMessage RemoveDriver([FromBody] UserDTO driver)
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.DeleteDriver(driver));
        }
        #endregion

        #region Rider CRUD
        [HttpGet]
        [Route("get-rider")]
        public HttpResponseMessage GetRider([FromUri] string username)
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.RequestRider(username), "application/json");
        }

        [HttpGet]
        [Route("get-riders")]
        public HttpResponseMessage GetRiders()
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.RequestRiders(), "application/json");
        }

        [HttpPut]
        [Route("update-rider")]
        public HttpResponseMessage UpdateRider([FromBody] UserDTO rider)
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.ModifyRider(rider));
        }

        [HttpPost]
        [Route("remove-rider")]
        public HttpResponseMessage RemoveRider([FromBody] UserDTO rider)
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.DeleteRider(rider));
        }
        #endregion

        #region User Approval
        [HttpPost]
        [Route("approve-user")]
        public HttpResponseMessage ApproveUser([FromBody] UserDTO user)
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.ApproveUser(user));
        }

        [HttpPost]
        [Route("approve-driver")]
        public HttpResponseMessage ApproveDriver([FromBody] UserDTO user)
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.ApproveDriver(user));
        }

        [HttpGet]
        [Route("get-pending-riders")]
        public HttpResponseMessage GetPendingRiders()
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.GetPendingRiders(), "application/json");
        }

        [HttpGet]
        [Route("get-pending-drivers")]
        public HttpResponseMessage GetPendingDrivers()
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.GetPendingDrivers(), "application/json");
        }
        #endregion

        #region User Reporting
        [HttpGet]
        [Route("get-user-reports")]
        public HttpResponseMessage UserReports()
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.GetUserReports(), "application/json");
        }

        [HttpPost]
        [Route("remove-report")]
        public HttpResponseMessage RemoveReport([FromBody] FlagDTO report)
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.RemoveReport(report));
        }

        [HttpPost]
        [Route("remove-driver-privileges")]
        public HttpResponseMessage RemoveDriverPrivileges([FromBody] FlagDTO report)
        {
            return Request.CreateResponse(HttpStatusCode.OK, adminLogic.RemoveDriverPrivileges(report));
        }
        #endregion
    }
}