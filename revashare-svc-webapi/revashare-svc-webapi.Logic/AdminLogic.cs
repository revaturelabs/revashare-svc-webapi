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
        #region Admin CRUD Methods
        public bool InsertAdmin(UserDTO adminToAdd)
        {
            return true;
        }

        public List<UserDTO> RequestAdmins()
        {
            return new List<UserDTO>();
        }

        public bool ModifyAdmin(UserDTO adminToUpdate)
        {
            return true;
        }

        public bool DeleteAdmin(UserDTO adminToRemove)
        {
            return true;
        }
        #endregion
    }
}
