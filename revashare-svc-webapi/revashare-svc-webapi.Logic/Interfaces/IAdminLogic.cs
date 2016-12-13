using revashare_svc_webapi.Logic.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Interfaces
{
    public interface IAdminLogic
    {
        List<AdminDTO> GetAllAdmins();

        bool AddDriver(DriverDTO DriverToAdd);


    }
}
