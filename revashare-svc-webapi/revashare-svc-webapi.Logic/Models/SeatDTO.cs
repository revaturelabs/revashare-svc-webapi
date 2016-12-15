using revashare_svc_webapi.Logic.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Models
{
   public class SeatDTO
   {
      public RideDTO ride { get; set; }
      public UserDTO rider { get; set; }
      public bool Accepted { get; set; }
   }
}
