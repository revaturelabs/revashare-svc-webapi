using Moq;
using NSubstitute;
using revashare_svc_webapi.Client.Controllers;
using revashare_svc_webapi.Logic.AdminLogic;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using revashare_svc_webapi.Logic.RiderLogic;
using revashare_svc_webapi.Logic.ServiceClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Xunit;

namespace revashare_svc_webapi.Tests
{
  public class VehicleTests
  {

    [Fact]
    public void test_GetVehicles()
    {
      RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();

      List<VehicleDAO> getVehicles = dataClient.GetVehicles().ToList();

      Assert.NotNull(getVehicles);

    }
    [Fact]
    public void test_GetVehicles_RiderLogic()
    {
      ServiceClient sc = new ServiceClient();
      RiderLogic rdrLogic = new RiderLogic(sc);
      var a = rdrLogic.getVehicles();


      Assert.NotEmpty(a);

    }

    [Fact]
    public void test_getVehicleByOwner_RiderLogic()
    {
      ServiceClient sc = new ServiceClient();
      RiderLogic rdrLogic = new RiderLogic(sc);
      var name = new UserDTO { Name = "name 4" };
      var a = rdrLogic.getVehicleByOwner(name);


      Assert.NotNull(a);

    }


    [Fact]
    public void Test_ViewPassengers()
    {
      var mock = new Mock<IDriverRepository>();
      mock.Setup(m => m.ViewPassengers(new RideDTO()));


      var ctrl = new DriverController(mock.Object);
      ctrl.Request = Substitute.For<HttpRequestMessage>();
      ctrl.Configuration = Substitute.For<HttpConfiguration>();
      HttpResponseMessage res = ctrl.ViewPassengers(new RideDTO());

      Assert.Equal(res.StatusCode, HttpStatusCode.OK);
    }


  }
}
