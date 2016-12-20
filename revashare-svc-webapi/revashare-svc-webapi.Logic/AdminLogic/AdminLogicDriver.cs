using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.AdminLogic
{
    public partial class AdminLogic : IAdmin
    {
        public bool InsertDriver(UserDTO driverToAdd)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> RequestDrivers()
        {
            throw new NotImplementedException();
        }

        public bool ModifyDriver(UserDTO driverToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDriver(UserDTO driverToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
