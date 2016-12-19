using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.Model;

namespace revashare_svc_webapi.Logic.RiderLogic
{
   
   public partial class RiderLogic : IRider
   {
      public List<RideDTO> getAvailableRides(string startLocation)
      {
         var list = sc.getRidesByLocation(startLocation);
         var ret = new List<RideDTO>();
         foreach (var item in list)
         {
            ret.Add(Mappers.RideMapper.mapToRideDTO(item));
         }
         return ret;
      }
      public List<RideDTO> getRides()
      {
         var list = sc.GetRides();
         var toReturn = new List<RideDTO>();
         foreach (var item in list)
         {
            toReturn.Add(Mappers.RideMapper.mapToRideDTO(item));
         }
         return toReturn;
      }

      public int getAvailableSeatsInRide(RideDTO ride)
      {
         return sc.getAvailableSeatsByRide(Mappers.RideMapper.mapToRideDAO(ride));
      }

      public RideDTO getCurrentSelectedRide(RideDTO ride)
      {
         return getRides().Where(m => m.Vehicle.LicensePlate.Equals(ride.Vehicle.LicensePlate)).FirstOrDefault();
      }

      
   }
   
}
