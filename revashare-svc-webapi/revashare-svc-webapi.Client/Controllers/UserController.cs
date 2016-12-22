using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace revashare_svc_webapi.Client.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        private IUser userLogic;

        public UserController(IUser UL)
        {
            userLogic = UL;
        }

        [HttpGet]
        [Route("get-user")]
        public HttpResponseMessage GetUser([FromUri] string username)
        {
            return Request.CreateResponse(HttpStatusCode.OK, userLogic.GetUser(username), "application/json");
        }

        [HttpGet]
        [Route("get-apartment")]
        public HttpResponseMessage GetApartment([FromUri] string name)
        {
            return Request.CreateResponse(HttpStatusCode.OK, userLogic.GetApartment(name), "application/json");
        }

        [HttpGet]
        [Route("get-apartments")]
        public HttpResponseMessage GetApartments()
        {
            return Request.CreateResponse(HttpStatusCode.OK, userLogic.GetApartments(), "application/json");
        }
    }
}
