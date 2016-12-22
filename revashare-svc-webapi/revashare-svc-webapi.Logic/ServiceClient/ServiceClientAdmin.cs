﻿using revashare_svc_webapi.Logic.Interfaces;
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
        public bool InsertAdmin(UserDAO adminToAdd)
        {
            throw new NotImplementedException();
        }

        public List<UserDAO> RequestAdmins()
        {
            return rs.GetAdmins().ToList();
        }

        public UserDAO RequestAdmin(string UserName)
        {
            return rs.GetAdminByUsername(UserName);
        }

        public bool ModifyAdmin(UserDAO adminToUpdate)
        {
            return rs.UpdateUser(adminToUpdate);
        }

        public bool DeleteAdmin(string UserName)
        {
            return rs.DeleteUser(UserName);
        }

        public bool AproveDriver(string UserName)
        {
            return rs.ApproveDriver(UserName);
        }

        public bool AproveUser(string UserName)
        {
            return rs.ApproveRider(UserName);
        }
        public List<UserDAO> PendingRegistrations()
        {
            return rs.GetPendingRiders().ToList();
        }

        public List<UserDAO> PendingDriverAprovals()
        {
            return rs.GetPendingDrivers().ToList();
        }
    }
}
