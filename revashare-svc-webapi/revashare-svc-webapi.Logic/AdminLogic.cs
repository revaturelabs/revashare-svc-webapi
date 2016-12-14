using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.ModelDTO;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;

namespace revashare_svc_webapi.Logic
{
    public class AdminLogic : IAdminLogic
    {

        public bool InsertDriver(DriverDTO driverToAdd)
        {
            return true;
        }

    }
}
