using revashare_svc_webapi.Logic.AdminLogic;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using revashare_svc_webapi.Logic.RiderLogic;
using revashare_svc_webapi.Logic.ServiceClient;
using revashare_svc_webapi.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Client.Controllers;
using NSubstitute;
using System.Net.Http;
using System.Web.Http;
using System.Net;

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
      UserDAO user = client.GetUserByUsername("testrider");
      RideDAO ride = client.GetAllRides().Single(x => x.Vehicle.Make.Equals("test make"));
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
    /*
    [Fact]
    public void test_acceptRideRequest_RiderLogic()
    {
      ServiceClient sc = new ServiceClient();
      RiderLogic rdrLogic = new RiderLogic(sc);
      var accept = new RideRiderDTO { RideId =  , RiderId = , Accepted = true};
      var a = rdrLogic.getVehicleByOwner(accept);


      Assert.True(a);

    }
    */

    [Fact]
    public void Test_acceptRideRequest()
    {
      var mock = new Mock<IDriverRepository>();
      mock.Setup(m => m.AcceptPassenger(new RideRiderDTO()))
        .Returns(true);

      var ctrl = new DriverController(mock.Object);
      ctrl.Request = Substitute.For<HttpRequestMessage>();
      ctrl.Configuration = Substitute.For<HttpConfiguration>();
      HttpResponseMessage res = ctrl.AcceptPassenger(new RideRiderDTO());

      Assert.Equal(res.StatusCode, HttpStatusCode.OK);
    }

    /*  Doesn't have a method within DriverController for removing a passenger
    [Fact]
    public void Test_RemovePassenger()
    {
      var mock = new Mock<IDriverRepository>();
      mock.Setup(m => m.RemovePassenger(new RideRiderDTO()))
        .Returns(true);

      var ctrl = new DriverController(mock.Object);
      ctrl.Request = Substitute.For<HttpRequestMessage>();
      ctrl.Configuration = Substitute.For<HttpConfiguration>();
      HttpResponseMessage res = ctrl.(new RideRiderDTO());

      Assert.Equal(res.StatusCode, HttpStatusCode.OK);
    }
    */

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


    [Fact]
    public void test_GetRideRiders_RiderLogic()
    {
      ServiceClient sc = new ServiceClient();
      RiderLogic rdrLogic = new RiderLogic(sc);
      var a = rdrLogic.getRideRiders();


      Assert.NotEmpty(a);

    }

    [Fact]
    public void test_GetRideRidersByName_RiderLogic()
    {
      ServiceClient sc = new ServiceClient();
      RiderLogic rdrLogic = new RiderLogic(sc);
      var user = new UserDTO { Name = "name 4" };
      var a = rdrLogic.getRideRidersByUser(user);


      Assert.NotEmpty(a);

    }

    [Fact]
    public void test_GetRidersByRide_RiderLogic()
    {
      ServiceClient sc = new ServiceClient();
      RiderLogic rdrLogic = new RiderLogic(sc);
      var LicensePlate = new RideDTO { Vehicle = new VehicleDTO { LicensePlate = "zxc-vbn" } };
      var a = rdrLogic.GetRidersByRide(LicensePlate);


      Assert.NotEmpty(a);

    }

    [Fact]
    public void test_getOccupiedSeatsByRide_RiderLogic()
    {
      ServiceClient sc = new ServiceClient();
      RiderLogic rdrLogic = new RiderLogic(sc);
      var LicensePlate = new RideDTO { Vehicle = new VehicleDTO { LicensePlate = "zxc-vbn" } };
      var a = rdrLogic.getOccupiedSeatsByRide(LicensePlate);


      Assert.NotNull(a);

    }


  }

}
