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

    [Fact]
    public void test_GetRideRiders()
    {
      RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();

      List<RideRidersDAO> getRideRiders  = dataClient.GetRideRiders().ToList();

      Assert.NotNull(getRideRiders);

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
      var user = new UserDTO{ Name = "john bob"};
      var a = rdrLogic.getRideRidersByUser(user);


      Assert.NotEmpty(a);

    }

    [Fact]
    public void test_GetRidersByRide_RiderLogic()
    {
      ServiceClient sc = new ServiceClient();
      RiderLogic rdrLogic = new RiderLogic(sc);
      var LicensePlate = new RideDTO { Vehicle = new VehicleDTO{ LicensePlate = "zxc-vbn" } };
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
