using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace revashare_svc_webapi.Client.Controllers
{
    public class RegisterController : ApiController
    {
        private readonly IRegisterLogic Repo;

        public RegisterController(IRegisterLogic repo)
        {
            this.Repo = repo;
        }

        [HttpPost]
        [Route("register-rider-account")]
        public HttpResponseMessage RegisterDriverAccount([FromBody] UserDTO rider)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.RegisterRider(rider));
        }

        [HttpPost]
        [Route("register-driver-account")]
        public HttpResponseMessage RequestDriverAccount([FromBody] UserDTO driver)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.RegisterDriver(driver));
        }

        [HttpPost]
        [Route("register-admin-account")]
        public HttpResponseMessage RegisterAdminAccount([FromBody] UserDTO admin)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.Repo.RegisterAdmin(admin));
        }
    }
}
