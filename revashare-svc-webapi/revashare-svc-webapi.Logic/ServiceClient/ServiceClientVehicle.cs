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
         //return rs.deleteVehicle(v);
         throw new NotImplementedException();
      }

      public List<VehicleDAO> GetVehicle()
      {
         //return rs.GetVehicle();
         throw new NotImplementedException();
      }

      public bool InsertVehicle(VehicleDAO v)
      {
         //return rs.InsertVehicle(v);
         throw new NotImplementedException();
      }

      public bool UpdateVehicle(VehicleDAO v)
      {
         //return rs.UpdateVehicle(v);
         throw new NotImplementedException();
      }
   }
   
}
