using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Models
{
   public class RideDTO
   {
      public int VehicleId { get; set; }
      public DateTime StartOfWeekDate { get; set; }
      public DateTime DepartureTime { get; set; }
      public bool IsOnTime { get; set; }
      public virtual VehicleDTO RideVehicle { get; set; }
   }
}
