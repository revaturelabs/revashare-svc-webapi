using revashare_svc_webapi.Logic.AdminLogic;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.ServiceClient;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web;

namespace revashare_svc_webapi.Client.Models.OwinModels
{
    public class Admin : User
    {

        private IAdmin logic;

        public Admin(ClaimsPrincipal principal) : base(principal)
        {
            this.logic = new AdminLogic(new ServiceClient());
        }

        public override bool isRider()
        {
            return false;
        }

        public override bool isDriver()
        {
            return false;
        }


        public override bool InsertAdmin(UserDTO adminToAdd, string password)
        {
            return logic.InsertAdmin(adminToAdd, password);
        }

        public override List<UserDTO> RequestAdmins()
        {
            return logic.RequestAdmins();
        }

        public override UserDTO RequestAdmin(string UserName)
        {
            return logic.RequestAdmin(userName);
        }

        public override bool ModifyAdmin(UserDTO adminToUpdate)
        {
            return logic.ModifyAdmin(adminToUpdate);
        }

        public override bool DeleteAdmin(string UserName)
        {
            return logic.DeleteAdmin(UserName);
        }

        public override bool ApproveUser(UserDTO userToApprove)
        {
            return logic.ApproveUser(userToApprove);
        }

        public override bool ApproveDriver(UserDTO driverToApprove)
        {
            return logic.ApproveDriver(driverToApprove);
        }

        public override List<UserDTO> GetPendingRiders()
        {
            return logic.GetPendingRiders();
        }

        public override List<UserDTO> GetPendingDrivers()
        {
            return logic.GetPendingDrivers();
        }

        public override UserDTO RequestDriver(string UserName)
        {
            return logic.RequestDriver(UserName);
        }

        public override List<UserDTO> RequestDrivers()
        {
            return logic.RequestDrivers();
        }

        public override bool ModifyDriver(UserDTO driverToUpdate)
        {
            return logic.ModifyDriver(driverToUpdate);
        }

        public override bool DeleteDriver(UserDTO driverToRemove)
        {
            return logic.DeleteDriver(driverToRemove);
        }

        public override List<FlagDTO> GetUserReports()
        {
            return logic.GetUserReports();
        }

        public override bool RemoveReport(FlagDTO reportToRemove)
        {
            return logic.RemoveReport(reportToRemove);
        }

        public override bool RemoveDriverPrivileges(FlagDTO reportForUser)
        {
            return logic.RemoveDriverPrivileges(reportForUser);
        }

        public override UserDTO RequestRider(string UserName)
        {
            return logic.RequestRider(UserName);
        }

        public override List<UserDTO> RequestRiders()
        {
            return logic.RequestRiders();
        }

        public override bool ModifyRider(UserDTO riderToUpdate)
        {
            return logic.ModifyRider(riderToUpdate);
        }

        public override bool DeleteRider(UserDTO riderToRemove)
        {
            return logic.DeleteRider(riderToRemove);
        }


    }

}