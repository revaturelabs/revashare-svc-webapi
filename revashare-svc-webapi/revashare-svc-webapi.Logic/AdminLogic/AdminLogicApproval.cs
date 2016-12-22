using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Mappers;
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
            List<UserDTO> pendingRiders = new List<UserDTO>();

            foreach (var user in sc.PendingRegistrations())
            {
                pendingRiders.Add(UserMapper.mapToUserDTO(user));
            }

            return pendingRiders;
        }

        public List<UserDTO> GetPendingDrivers()
        {
            List<UserDTO> pendingDrivers = new List<UserDTO>();

            foreach (var user in sc.PendingRegistrations())
            {
                pendingDrivers.Add(UserMapper.mapToUserDTO(user));
            }

            return pendingDrivers;
        }
    }
}
