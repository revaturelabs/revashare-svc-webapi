using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Mappers
{
   public class VehicleMapper
   {
      public static VehicleDTO mapToVehicleDTO(VehicleDAO b)
      {
         var a = new VehicleDTO();
         a.Capacity = b.Capacity;
         a.Color = b.Color;
         a.LicensePlate = b.LicensePlate;
         a.Make = b.Make;
         a.Model = b.Model;
         a.Owner = UserMapper.mapToUserDTO(b.Owner);
         return a;
      }

      public static VehicleDAO mapToVehicleDAO(VehicleDTO b)
      {
         var a = new VehicleDAO();
         a.Capacity = b.Capacity;
         a.Color = b.Color;
         a.LicensePlate = b.LicensePlate;
         a.Make = b.Make;
         a.Model = b.Model;
         a.Owner = UserMapper.mapToUserDAO(b.Owner);
         return a;
      }
   }
}
