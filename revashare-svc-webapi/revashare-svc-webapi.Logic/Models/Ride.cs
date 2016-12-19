using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Models
{
   public class Ride
   {
      public User Driver { get; set; }
      public User[] Riders { get; set; }
      public TimeSpan? DepartureTime { get; set; }
      public int Capacity { get; set; }
      public int CurrentlySeated { get; set; }
      public VehicleDTO Vehicle { get; set; }
      
   }
}
