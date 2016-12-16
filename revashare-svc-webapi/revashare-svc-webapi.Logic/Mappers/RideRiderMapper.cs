using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Mappers
{
   public static class RideRiderMapper
   {
      
      public static RideRiderDTO mapToRideRiderDTO(RideRidersDAO b)
      {
         var a = new RideRiderDTO();
         a.Accepted = b.Accepted;
         if(b.Ride!=null)
         {
            a.Ride = RideMapper.mapToRideDTO( b.Ride);
         }
         if (b.Rider != null)
         {
            a.Rider = UserMapper.mapToUserDTO( b.Rider);
         }
         return a;
      }

      public static RideRidersDAO mapToRideRiderDAO(RideRiderDTO b)
      {
         var a = new RideRidersDAO();
         a.Accepted = b.Accepted;
         if(b.Ride!=null)
         {
            a.Ride = RideMapper.mapToRideDAO(b.Ride);
         }
         if (b.Rider != null)
         {
            a.Rider = UserMapper.mapToUserDAO(b.Rider);
         }         
         return a;
      }
      

   }
}
