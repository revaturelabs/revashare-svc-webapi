﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Interfaces
{
    public interface IRegisterLogic
    {
        bool RegisterRider(UserDTO riderToRegister);

        bool RegisterDriver(UserDTO driverToRegister);

        bool RegisterAdmin(UserDTO adminToRegister);
    }
}
