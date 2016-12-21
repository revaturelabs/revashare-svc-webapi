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
        public bool ApproveUser(UserDTO userToApprove)
        {
            return sc.AproveUser(userToApprove.UserName);
        }
        
        public bool ApproveDriver(UserDTO driverToApprove)
        {
            return sc.AproveDriver(driverToApprove.UserName);
        }

        public List<UserDTO> GetPendingRiders()
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> GetPendingDrivers()
        {
            throw new NotImplementedException();
        }
    }
}
