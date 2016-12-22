using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.ServiceClient
{
   public partial class ServiceClient:IServiceClient
   {
      public bool DeleteVehicle(VehicleDAO v)
      {
         return rs.DeleteVehicle(v);
      }

      public List<VehicleDAO> GetVehicle()
      {
         return rs.GetVehicles().ToList();
         
      }

      public bool InsertVehicle(VehicleDAO v)
      {
         return rs.AddVehicle(v);
      }

      public bool UpdateVehicle(VehicleDAO v)
      {
         return rs.UpdateVehicle(v);
      }
   }
   
}
