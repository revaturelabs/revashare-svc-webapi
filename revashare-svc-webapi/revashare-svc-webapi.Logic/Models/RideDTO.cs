using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Models
{
   public class RideDTO
   {      
      public DateTime StartOfWeekDate { get; set; }
      public TimeSpan? DepartureTime { get; set; }
      public bool IsOnTime { get; set; }
      public virtual VehicleDTO Vehicle { get; set; }
      public bool IsAMRide { get; set; }
   }
}
