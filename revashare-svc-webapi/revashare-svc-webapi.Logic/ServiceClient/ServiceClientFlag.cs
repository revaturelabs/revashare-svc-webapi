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
      public bool deleteFlag(FlagDAO flag)
      {
         sr.deleteFlag(flag);
      }

      public List<FlagDAO> GetFlags()
      {
         sr.GetFlags();
      }

      public bool InsertFlag(FlagDAO flag)
      {
         sr.InsertFlag(flag);
      }

      public bool UpdateFlag(FlagDAO flag)
      {
         sr.UpdateFlag(flag);
      }
   }
}
