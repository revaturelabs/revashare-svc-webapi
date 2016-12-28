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
        bool InsertAdmin(UserDTO adminToAdd, string Password);
        List<UserDTO> RequestAdmins();
        UserDTO RequestAdmin(string UserName);
        bool ModifyAdmin(UserDTO adminToUpdate);
        bool DeleteAdmin(string UserName);

        //Driver CRUD Methods
        UserDTO RequestDriver(string UserName);
        List<UserDTO> RequestDrivers();
        bool ModifyDriver(UserDTO driverToUpdate);
        bool DeleteDriver(UserDTO driverToRemove);

        //Rider CRUD Methods
        UserDTO RequestRider(string UserName);
        List<UserDTO> RequestRiders();
        bool ModifyRider(UserDTO riderToUpdate);
        bool DeleteRider(UserDTO riderToRemove);

        //Ride CRUD Methods
        bool InsertRide(RideDTO ride);
        RideDTO GetRide(RideDTO ride);
        List<RideDTO> GetRides();
        bool ModifyRide(RideDTO ride);
        bool DeleteRide(RideDTO ride);

        //User Approval
        bool ApproveUser(UserDTO userToApprove);
        bool ApproveDriver(UserDTO driverToApprove);
        List<UserDTO> GetPendingRiders();
        List<UserDTO> GetPendingDrivers();

        //User Reporting
        List<FlagDTO> GetUserReports(UserDTO user);
        FlagDTO GetReport(int id);
        List<FlagDTO> GetReports();
        bool RemoveReport(FlagDTO reportToRemove);
        bool RemoveDriverPrivileges(UserDTO user);

        //Apartment Methods
        bool AddApartment(ApartmentDTO apt);
        ApartmentDTO GetApartment(string name);
        List<ApartmentDTO> GetApartments();
        bool UpdateApartment(ApartmentDTO apt);
        bool RemoveApartment(ApartmentDTO apt);
    }
}
