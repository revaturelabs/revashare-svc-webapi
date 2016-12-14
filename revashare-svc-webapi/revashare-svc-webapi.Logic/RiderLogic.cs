using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.ModelDTO;

namespace revashare_svc_webapi.Logic
{
   
   public partial class RiderLogic : IRider
   {
      private IServiceClient sc;
      public RiderLogic(IServiceClient client)
      {
         sc = client;
      }
      public bool addRiderToRide(RideDTO ride, UserDTO rider)
      {
         throw new NotImplementedException();
         //return sc.InsertRideRider(Mappers.RideMapper.mapToRideDAO(ride), Mappers.RiderMapper.mapToRiderDAO(rider));
      }

      public List<RideDTO> getAvailableRides(string startLocation)
      {
         //List<ApartmentDTO> apartmentList = getApartments();
         throw new NotImplementedException();
      }

      public int getAvailableSeatsInRide(RideDTO ride)
      {
         throw new NotImplementedException();
      }

      public RideDTO getCurrentSelectedRide(UserDTO user)
      {
         throw new NotImplementedException();
      }

      public bool modifyCurrentSelectedRide(UserDTO user, RideDTO ride)
      {
         throw new NotImplementedException();
      }

      public bool modifyRiderInfo(UserDTO user)
      {
         throw new NotImplementedException();
      }

      public bool removeRiderFromRide(UserDTO user, RideDTO ride)
      {
         throw new NotImplementedException();
      }

      public bool requestToBeDriver(UserDTO user)
      {
         throw new NotImplementedException();
      }
   }
   
}
