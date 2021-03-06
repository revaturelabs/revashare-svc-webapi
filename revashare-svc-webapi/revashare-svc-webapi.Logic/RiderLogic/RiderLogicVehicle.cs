﻿using revashare_svc_webapi.Logic.Interfaces;
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
      public List<VehicleDTO> getVehicles()
      {
         var list = sc.GetVehicle();
         var ret = new List<VehicleDTO>();
         foreach (var item in list)
         {
            ret.Add(Mappers.VehicleMapper.mapToVehicleDTO(item));
         }
         return ret;
      }
      public VehicleDTO getVehicleByOwner(UserDTO owner)
      {
         var ret = getVehicles().Where(m => m.Owner.Name.Equals(owner.Name)).FirstOrDefault();
         return ret;
      }
   }
}
