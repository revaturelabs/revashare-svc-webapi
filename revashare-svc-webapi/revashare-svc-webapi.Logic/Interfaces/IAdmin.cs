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
        bool ModifyAdmin(UserDTO adminToUpdate);
        bool DeleteAdmin(UserDTO adminToRemove);

        //Driver CRUD Methods
        bool InsertDriver(UserDTO driverToAdd);
        List<UserDTO> RequestDrivers();
        bool ModifyDriver(UserDTO driverToUpdate);
        bool DeleteDriver(UserDTO driverToRemove);

        //Rider CRUD Methods
        bool InsertRider(UserDTO riderToAdd);
        List<UserDTO> RequestRiders();
        bool ModifyRider(UserDTO riderToUpdate);
        bool DeleteRider(UserDTO riderToRemove);

        //User Approval
        bool ApproveUser(UserDTO userToApprove);
        List<UserDTO> GetPendingRiders();
        List<UserDTO> GetPendingDrivers();
        List<UserDTO> GetPendingAdmins();

        //User Reporting
        List<FlagDTO> GetUserReports();
        bool RemoveReport(FlagDTO reportToRemove);
        bool RemoveDriverPrivileges(FlagDTO reportForUser);
    }
}
