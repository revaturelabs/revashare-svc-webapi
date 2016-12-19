using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.RiderLogic
{
   public partial class RiderLogic :IRider
   {
      private IServiceClient sc;
      public RiderLogic(IServiceClient client)
      {
         sc = client;
      }

      public bool requestToBeDriver(DriverEnrollDTO enroll)
      {        
         enroll.MyCar.Owner = enroll.User;
         var insert = sc.InsertVehicle(Mappers.VehicleMapper.mapToVehicleDAO(enroll.MyCar));
         var request = sc.RequestToBeDriver(enroll.User.Name);
         return (insert && request);
      }
   }
}
