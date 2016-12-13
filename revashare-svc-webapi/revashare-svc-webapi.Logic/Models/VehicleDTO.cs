using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Models {
  public class VehicleDTO {
    public int Id { get; set; }

    public int OwnerId { get; set; }

    public string Make { get; set; }

    public string Model { get; set; }

    public string LicensePlate { get; set; }

    public string Color { get; set; }

    public int Capacity { get; set; }
  }
}
