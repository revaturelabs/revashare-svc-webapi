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

      public bool DeleteRideRider(RideRidersDAO rr)
      {
         //return rs.DeleteRideRider(rr);
         throw new NotImplementedException();
      }

      public List<RideRidersDAO> GetRideRiders()
      {
         return rs.GetRideRiders().ToList();
      }

      public bool InsertRideRider(UserDAO rider, RideDAO ride)
      {
         
         
         return rs.AddRideRiders(rider,ride);
         
      }

      public bool UpdateRideRider(RideRidersDAO rr)
      {
         return rs.UpdateRideRider(rr);         
      }

   }
}
