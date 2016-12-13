using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Models {
  public class FlagDTO {
    public int Id { get; set; }

    public string Type { get; set; }

    public string Message { get; set; }

    public int DriverId { get; set; }

    public int RiderId { get; set; }
  }
}
