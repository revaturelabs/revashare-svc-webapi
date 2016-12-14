using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.ServiceClient
{
   public partial class ServiceClient:IServiceClient
   {
      public bool deleteVehicle(VehicleDAO v)
      {
         sr.deleteVehicle(v);
      }

      public List<VehicleDAO> GetVehicle()
      {
         sr.GetVehicle();
      }

      public bool InsertVehicle(VehicleDAO v)
      {
         sr.InsertVehicle(v);
      }

      public bool UpdateVehicle(VehicleDAO v)
      {
         sr.UpdateVehicle(v);
      }
   }
}
