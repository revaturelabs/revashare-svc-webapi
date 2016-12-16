using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic
{
    public class RegisterLogic
    {
        private RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();

        bool RegisterRider(UserDTO riderToRegister)
        {
            return true;
        }

        bool RegisterDriver(UserDTO driverToRegister)
        {
            return true;
        }

        bool RegisterAdmin(UserDTO adminToRegister)
        {
            return true;
        }
    }
}
