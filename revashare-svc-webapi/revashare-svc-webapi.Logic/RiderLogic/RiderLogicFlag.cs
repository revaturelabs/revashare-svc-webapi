using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.RiderLogic
{
   public partial class RiderLogic:IRider
   {
      public bool fileComplaintAboutDriver(FlagDTO flag )
      {
         return sc.InsertFlag(Mappers.FlagMapper.mapToFlagDAO(flag));
      }
   }
}
