using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Models {
  public class FlagDTO
   {

    public string Type { get; set; }

    public string Message { get; set; }

    public int DriverId { get; set; }

    public int RiderId { get; set; }

    public UserDTO Driver { get; set; }

    public UserDTO Rider { get; set; }
   }
}
