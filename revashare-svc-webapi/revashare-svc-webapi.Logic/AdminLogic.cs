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
        private RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();

        #region Driver Related
        public bool InsertDriver(UserDTO driverToAdd)
        {
            return true;
        }

        public List<UserDTO> RequestDrivers()
        {
            return new List<UserDTO>();
        }

        public bool ModifyDriver(UserDTO driverToUpdate)
        {
            return true;
        }

        public bool DeleteDriver(UserDTO driverToRemove)
        {
            return true;
        }
        #endregion

        #region Rider Related
        public bool InsertRider(UserDTO riderToAdd)
        {
            return true;
        }
        #endregion
    }
}
