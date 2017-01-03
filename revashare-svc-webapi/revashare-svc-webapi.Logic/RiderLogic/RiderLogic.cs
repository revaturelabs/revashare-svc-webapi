using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;

namespace revashare_svc_webapi.Logic.RiderLogic
{
    public partial class RiderLogic : IRider
    {
        private IServiceClient sc;
        public RiderLogic(IServiceClient client)
        {
            sc = client;
        }

        public bool requestToBeDriver(DriverEnrollDTO enroll)
        {
            enroll.MyCar.Owner = enroll.User;

            bool insertVehicle = sc.InsertVehicle(Mappers.VehicleMapper.mapToVehicleDAO(enroll.MyCar));

            if (insertVehicle)
            {
                bool driverUpgrade = sc.RequestToBeDriver(enroll.User.UserName);
                return driverUpgrade;
            }
            else
            {
                return false;
            }

        }
    }
}
