using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Models
{
   public class ApartmentDTO: IEquatable<ApartmentDTO>
   {
      public string Latitude { get; set; }

      public string Longitude { get; set; }

      public string Name { get; set; }

      public bool Equals(ApartmentDTO other)
      {
            return this.Latitude.Equals(other.Latitude)
                    && this.Longitude.Equals(other.Longitude)
                    && this.Name.Equals(other.Name);
      }

    }
}
