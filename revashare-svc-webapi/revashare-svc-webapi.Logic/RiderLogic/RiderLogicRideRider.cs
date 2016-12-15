using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.RiderLogic
{
   public partial class RiderLogic : IRider
   {
      public bool addRiderToRide(RideDTO ride, UserDTO rider)
      {
         throw new NotImplementedException();
         //return sc.InsertRideRider(Mappers.RideMapper.mapToRideDAO(ride), Mappers.RiderMapper.mapToRiderDAO(rider));
      }

      public bool removeRiderFromRide(UserDTO user, RideDTO ride)
      {
         throw new NotImplementedException();
      }

      public List<RideRiderDTO> getRideRidersByUser(UserDTO user)
      {
         throw new NotImplementedException();
      }
   }
}
