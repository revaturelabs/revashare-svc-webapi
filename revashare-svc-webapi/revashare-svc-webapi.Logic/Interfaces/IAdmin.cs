using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Interfaces
{
    public interface IAdmin
    {
        //Admin CRUD Methods
        bool InsertAdmin(UserDTO adminToAdd);
        List<UserDTO> RequestAdmins();
        UserDTO RequestAdmin(string UserName);
        bool ModifyAdmin(UserDTO adminToUpdate);
        bool DeleteAdmin(string UserName);

        //Driver CRUD Methods
        List<UserDTO> RequestDrivers();
        UserDTO RequestDriver(string UserName);
        bool ModifyDriver(UserDTO driverToUpdate);
        bool DeleteDriver(UserDTO driverToRemove);

        //Rider CRUD Methods
        List<UserDTO> RequestRiders();
        bool ModifyRider(UserDTO riderToUpdate);
        bool DeleteRider(UserDTO riderToRemove);

        //User Approval
        bool ApproveUser(UserDTO userToApprove);
        List<UserDTO> GetPendingRiders();
        List<UserDTO> GetPendingDrivers();

        //User Reporting
        List<FlagDTO> GetUserReports();
        bool RemoveReport(FlagDTO reportToRemove);
        bool RemoveDriverPrivileges(FlagDTO reportForUser);
    }
}
