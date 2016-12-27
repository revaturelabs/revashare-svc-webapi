using revashare_svc_webapi.Logic;
using revashare_svc_webapi.Logic.AdminLogic;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using revashare_svc_webapi.Logic.RiderLogic;
using revashare_svc_webapi.Logic.ServiceClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace revashare_svc_webapi.Tests
{
  public class RideRiderTests
  {
        private RiderLogic riderLogic;
        private DriverLogic driverLogic;

        public RideRiderTests()
        {
            this.riderLogic = new RiderLogic(new ServiceClient());
            this.driverLogic = new DriverLogic();
        }


        [Fact]
        public void test_GetRideRiders()
        {

            List<RideRiderDTO> getRideRiders = riderLogic.getRideRiders();

            Assert.NotNull(getRideRiders);

        }





        [Fact]
        public void test_insertRideRider()
        {

            List<UserDTO> riders = riderLogic.getRiders();
            List<RideDTO> rides = riderLogic.getRides();

            UserDTO selectedRider = riders.Single(x => x.UserName.Equals("not_gonna_remember_this"));
            RideDTO selectedRide = rides[1];

            
            bool success = riderLogic.addRiderToRide(selectedRide, selectedRider);
            
            Assert.True(success);

        }


        [Fact]
        public void temp_test()
        {
            RevaShareDataServiceClient client = new RevaShareDataServiceClient();
            UserDAO user = client.GetUserByUsername("fresh_new_user");
            RideDAO ride = client.GetAllRides().First();
            bool success = client.AddRideRiders(user, ride);
            Assert.True(success);
            
        }


        [Fact]
        public void temp_test_acceptPassenger()
        {
            RevaShareDataServiceClient client = new RevaShareDataServiceClient();
            RideDAO ride = client.GetAllRides()[1]; //.Single(x => x.Vehicle.LicensePlate.Equals("zxc-vbn"));
            UserDAO rider = client.GetRiders().Single(x => x.UserName.Equals("another_original_username_two"));

            bool success = client.AcceptRideRequest(new RideRidersDAO()
            {
                Ride = ride,
                Rider = rider
            });

            Assert.True(success);
        }


        [Fact]
        public void test_acceptRideRequest()
        {

            RideDTO ride = riderLogic.getRides()[0]; //.Single(x => x.Vehicle.LicensePlate.Equals("zxc-vbn"));
            UserDTO rider = riderLogic.getRiders().Single(x => x.UserName.Equals("fresh_new_user"));

            bool success = riderLogic.acceptPassenger(new RideRiderDTO()
            {
                Ride = ride,
                Rider = rider
            });

            Assert.True(success);

        }


        [Fact]
        public void test_removeRideRider()
        {

            List<UserDTO> riders = riderLogic.getRiders();
            List<RideDTO> rides = riderLogic.getRides();

            UserDTO selectedRider = riders.Single(x => x.UserName.Equals("another_original_username_two"));
            RideDTO selectedRide = rides[1];

            bool success = driverLogic.RemovePassenger(new RideRiderDTO()
            {
                Rider = selectedRider,
                Ride = selectedRide
            });

            Assert.True(success);

        }

    }
}
