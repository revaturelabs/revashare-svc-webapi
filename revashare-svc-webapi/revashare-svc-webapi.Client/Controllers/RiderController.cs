using revashare_svc_webapi.Logic;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RiderLogic;
using revashare_svc_webapi.Logic.ServiceClient;
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

      public RiderController()
      {
         riderLogic = new RiderLogic(new ServiceClient());
      }
      public RiderController(IRider RL)
      {
         riderLogic = RL;
      }
            
      //Post api/rider/get-rides
      [HttpPost]
      [Route("get-rides")]
      public HttpResponseMessage GetRides([FromBody] string location)
      {
         return Request.CreateResponse(HttpStatusCode.OK, getRidesHelper(location), "application/json");
      }
      private List<Ride> getRidesHelper(string location)
      {
         var a = riderLogic.getAvailableRides(location);
         var ret = new List<Ride>();

         foreach (var item in a)
         {
            var x = new Ride();
            x.Capacity = item.Vehicle.Capacity;
            x.CurrentlySeated = riderLogic.getOccupiedSeatsByRide(item);
            x.DepartureTime = item.DepartureTime;
            x.Driver = new User();
            x.Driver.AccountType = item.Vehicle.Owner.Roles.FirstOrDefault().Type;
            x.Driver.Email=item.Vehicle.Owner.Email;
            x.Driver.Apartment = item.Vehicle.Owner.Apartment;
            x.Driver.Name = item.Vehicle.Owner.Name;
            x.Driver.PhoneNumber = item.Vehicle.Owner.PhoneNumber;            
            x.Vehicle = item.Vehicle;
            var riders = riderLogic.GetRidersByRide(item);
            ret.Add(x);
         }
         return ret;
      }

      //Post api/rider/add-ride
      [HttpPost]
      [Route("add-ride")]
      public HttpResponseMessage AddRide([FromBody] SeatDTO seat)
      {         
         return Request.CreateResponse(HttpStatusCode.OK, riderLogic.addRiderToRide(seat.ride, seat.rider));
      }

      //Post api/rider/remove-ride
      [HttpPost]
      [Route("remove-ride")]
      public HttpResponseMessage RemoveRide([FromBody] RideRiderDTO seat)
      {
         return Request.CreateResponse(HttpStatusCode.OK, riderLogic.removeRiderFromRide(seat));
      }

      //Post api/rider/user-rides
      [HttpPost]
      [Route("user-rides")]
      public HttpResponseMessage UserRides([FromBody] UserDTO user)
      {
          return Request.CreateResponse(HttpStatusCode.OK, riderLogic.getRideRidersByUser(user), "application/json");
      }

      //Post api/rider/save-user
      [HttpPost]
      [Route("save-user")]
      public HttpResponseMessage SaveUser([FromBody] UserDTO user)
      {
         return Request.CreateResponse(HttpStatusCode.OK, riderLogic.modifyUserInfo(user));
      }

      //Post api/rider/apply-for-driver
      [HttpPost]
      [Route("apply-for-driver")]
      public HttpResponseMessage ApplyForDriver([FromBody] DriverEnrollDTO enroll)
      {
         return Request.CreateResponse(HttpStatusCode.OK, riderLogic.requestToBeDriver(enroll));
      }
   }
}