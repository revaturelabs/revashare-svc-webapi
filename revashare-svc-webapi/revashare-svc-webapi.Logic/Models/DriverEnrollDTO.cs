﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Models
{
   public class DriverEnrollDTO
   {
      public UserDTO User { get; set; }
      public VehicleDTO MyCar { get; set; }
   }
}
