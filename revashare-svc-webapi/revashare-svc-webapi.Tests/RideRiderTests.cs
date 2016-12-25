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
        private RiderLogic svc;
        private DriverLogic driverLogic;

        public RideRiderTests()
        {
            this.svc = new RiderLogic(ServiceClient.getClient());
            this.driverLogic = new DriverLogic();
        }


        [Fact]
        public void test_GetRideRiders()
        {

            List<RideRiderDTO> getRideRiders = svc.getRideRiders();

            Assert.NotNull(getRideRiders);

        }





        [Fact]
        public void test_insertRideRider()
        {

            List<UserDTO> riders = svc.getRiders();
            List<RideDTO> rides = svc.getRides();

            UserDTO selectedRider = riders.Single(x => x.UserName.Equals("testrider"));
            RideDTO selectedRide = rides.First();

            
            bool success = svc.addRiderToRide(selectedRide, selectedRider);

            Assert.True(success);

        }


        [Fact]
        public void test_acceptRideRequest()
        {

            RideDTO ride = svc.getRides().Single(x => x.Vehicle.LicensePlate.Equals("zxc-vbn"));
            UserDTO rider = svc.getRiders().Single(x => x.UserName.Equals("testrider"));

            bool success = svc.acceptPassenger(new RideRiderDTO()
            {
                Ride = ride,
                Rider = rider
            });

            Assert.True(success);

        }


        [Fact]
        public void test_removeRideRider()
        {

            List<UserDTO> riders = svc.getRiders();
            List<RideDTO> rides = svc.getRides();

            UserDTO selectedRider = riders.Single(x => x.UserName.Equals("testrider"));
            RideDTO selectedRide = rides.First();

            bool success = driverLogic.RemovePassenger(new RideRiderDTO()
            {
                Rider = selectedRider,
                Ride = selectedRide
            });

            Assert.True(success);

        }

    }
}
