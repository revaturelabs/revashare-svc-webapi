using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.ModelDTO;

namespace revashare_svc_webapi.Logic
{
    public class AdminLogic : IAdminLogic
    {
        public bool AddDriver(DriverDTO driverToAdd)
        {
            if (driverToAdd.name == "true")
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public List<AdminDTO> GetAllAdmins()
        {
            List<AdminDTO> adminList = new List<AdminDTO>();
            AdminDTO newAdmin = new AdminDTO { name = "Ray" };
            adminList.Add(newAdmin);

            return adminList;
        }
    }
}
