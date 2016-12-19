using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.ServiceClient
{
   public partial class ServiceClient :IServiceClient
   {
      public bool deleteFlag(FlagDAO flag)
      {
         //return rs.deleteFlag(flag);
         throw new NotImplementedException();
      }

      public List<FlagDAO> GetFlags()
      {
         return rs.GetAllFlags().ToList();
      }

      public bool InsertFlag(FlagDAO flag)
      {
         return rs.CreateFlag(flag);
      }

      public bool UpdateFlag(FlagDAO flag)
      {
         //return rs.UpdateFlag(flag);
         throw new NotImplementedException();
      }
      public FlagDAO GetFlagsById(FlagDAO flag)
      {
         return rs.GetFlagByID(flag.FlagID);
      }
   }
}
