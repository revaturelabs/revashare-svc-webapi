using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.ServiceClient
{
   public partial class ServiceClient : IServiceClient
   {

      public bool DeleteRide(RideDAO ride)
      {

         //return rs.deleteRide(ride);
         throw new NotImplementedException();
      }

      public List<RideDAO> GetRides()
      {
         //return rs.GetRides();
         throw new NotImplementedException();
      }

      public bool InsertRide(RideDAO ride)
      {
         //return rs.InsertRide(ride);
         throw new NotImplementedException();
      }

      public bool UpdateRide(RideDAO ride)
      {
         //return rs.UpdateRide(ride);
         throw new NotImplementedException();
      }
      public List<RideDAO> getRidesByLocation()
      {
         //return rs.GetRidesByLocation();
         throw new NotImplementedException();
      }
      public int getAvailableSeatsByRide(RideDAO ride)
      {
         //return rs.getAvailableSeatsByRide(ride);
         throw new NotImplementedException();
      }
   }
}
