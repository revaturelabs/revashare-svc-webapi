using revashare_svc_webapi.Logic.ModelDTO;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Interfaces
{
    public interface IAdminLogic
    {
        //Methods For Drivers
        bool InsertDriver(UserDTO driverToAdd);
        List<UserDTO> RequestDrivers();
        bool ModifyDriver(UserDTO driverToUpdate);
        bool DeleteDriver(UserDTO driverToRemove);

        //Methods For Riders
        bool InsertRider(UserDTO riderToAdd);
    }
}
