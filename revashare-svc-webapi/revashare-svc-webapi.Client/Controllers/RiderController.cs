using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace revashare_svc_webapi.Client.Controllers
{
   [RoutePrefix("api/rider")]
   public class RiderController : ApiController
   {
      private IRider riderLogic;

      public RiderController(IRider logic)
      {
         riderLogic = logic;
      }

      // GET api/rider
      [HttpGet]
      public void Get()
      {         
      }

      // GET api/rider/5
      //public string Get(int id)
      //{
      //   return "value";
      //}

      // POST api/rider>
      [HttpPost]
      public void Post([FromBody]string value)
      {
      }

      // PUT api/<controller>/5
      [HttpPut]
      public void Put(int id, [FromBody]string value)
      {
      }

      // DELETE api/<controller>/5
      [HttpDelete]
      public void Delete(int id)
      {
      }

      [HttpPost]
      [Route("get-rides")]
      public HttpResponseMessage GetRides([FromBody] string location)
      {
         return Request.CreateResponse(HttpStatusCode.OK, riderLogic.getAvailableRides(location), "application/json");
      }

      [HttpPost]
      [Route("add-ride")]
      public HttpResponseMessage AddRide([FromBody] SeatDTO seat)
      {         
         return Request.CreateResponse(HttpStatusCode.OK, riderLogic.addRiderToRide(seat.ride, seat.rider));
      }

      [HttpPost]
      [Route("remove-ride")]
      public HttpResponseMessage RemoveRide([FromBody] SeatDTO seat)
      {
         return Request.CreateResponse(HttpStatusCode.OK, riderLogic.removeRiderFromRide(seat.rider, seat.ride));
      }

      [HttpPost]
      [Route("user-rides")]
      public HttpResponseMessage UserRides([FromBody] UserDTO user)
      {
          return Request.CreateResponse(HttpStatusCode.OK, riderLogic.getRideRidersByUser(user), "application/json");
      }

      [HttpPost]
      [Route("save-user")]
      public HttpResponseMessage SaveUser([FromBody] UserDTO user)
      {
         return Request.CreateResponse(HttpStatusCode.OK, riderLogic.modifyUserInfo(user));
      }

      [HttpPost]
      [Route("apply-for-driver")]
      public HttpResponseMessage ApplyForDriver([FromBody] DriverEnrollDTO enroll)
      {
         return Request.CreateResponse(HttpStatusCode.OK, riderLogic.requestToBeDriver(enroll));
      }
   }
}