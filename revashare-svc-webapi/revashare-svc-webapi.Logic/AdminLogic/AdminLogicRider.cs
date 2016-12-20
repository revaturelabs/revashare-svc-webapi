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
        public bool InsertRider(UserDTO riderToAdd)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> RequestRiders()
        {
            throw new NotImplementedException();
        }

        public bool ModifyRider(UserDTO riderToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRider(UserDTO riderToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
