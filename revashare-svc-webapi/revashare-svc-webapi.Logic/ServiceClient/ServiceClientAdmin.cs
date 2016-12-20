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
    public partial class ServiceClient : IServiceClient
    {
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

        public bool AproveDriver(string UserName)
        {
            return rs.ApproveDriver(UserName);
        }

        public bool AproveUser(string UserName)
        {
            return rs.ApproveUser(UserName);
        }
        public List<UserDAO> PendingRegistrations()
        {
            return rs.PendingRegistrations().ToList();
        }

        public List<UserDAO> PendingDriverAprovals()
        {
            return rs.PendingDriverApprovals().ToList();
        }
    }
}
