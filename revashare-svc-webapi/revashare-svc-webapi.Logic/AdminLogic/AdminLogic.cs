﻿using revashare_svc_webapi.Logic.Interfaces;
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
        private IServiceClient sc;
        public AdminLogic(IServiceClient client)
        {
            sc = client;
        }

        public bool InsertAdmin(UserDTO adminToAdd)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> RequestAdmins()
        {
            throw new NotImplementedException();
        }

        public bool ModifyAdmin(UserDTO adminToUpdate)
        {
            throw new NotImplementedException();
        }
        public bool DeleteAdmin(UserDTO adminToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
