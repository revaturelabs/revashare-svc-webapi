using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Models {
   public class VehicleDTO
   {
       public string Make { get; set; }

       public string Model { get; set; }

       public string LicensePlate { get; set; }

       public string Color { get; set; }

       public int Capacity { get; set; }

       public UserDTO Owner { get; set; }

       public int OwnerId { get; set; }
   }
}
