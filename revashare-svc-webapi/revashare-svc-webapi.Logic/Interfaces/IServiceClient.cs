using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Interfaces
{
   public interface IServiceClient
   {
      /*
      List<RideDTO> GetRides();
      bool InsertRide(RideDAO ride);
      bool UpdateRide(RideDAO ride);
      bool deleteRide(RideDAO ride);

      //List<RideRiderDAO> GetRideRiders();
      //bool InsertRideRider(UserDAO rider, string user);
      //bool UpdateRideRider(RideRiderDAO rideRider);
      //bool deleteRideRider(RideRiderDAO rr);

   }
}
