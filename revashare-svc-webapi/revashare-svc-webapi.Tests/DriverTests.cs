using Moq;
using NSubstitute;
using revashare_svc_webapi.Client.Controllers;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Xunit;

namespace revashare_svc_webapi.Tests {
  public class DriverTests {
    [Fact]
    public void Test_UpdateVehicleInfo() {
      var mock = new Mock<IDriverRepository>();
      mock.Setup(m => m.UpdateVehicleInfo(new VehicleDTO()))
        .Returns(true);

      var ctrl = new DriverController(mock.Object);
      ctrl.Request = Substitute.For<HttpRequestMessage>();
      ctrl.Configuration = Substitute.For<HttpConfiguration>();
      HttpResponseMessage res = ctrl.Put(new VehicleDTO());

      Assert.Equal(res.StatusCode, HttpStatusCode.OK);
    }

    [Fact]
    public void Test_ReportRider() {
      var mock = new Mock<IDriverRepository>();
      mock.Setup(m => m.ReportRider(new FlagDTO()))
        .Returns(true);

      var ctrl = new DriverController(mock.Object);
      ctrl.Request = Substitute.For<HttpRequestMessage>();
      ctrl.Configuration = Substitute.For<HttpConfiguration>();
      HttpResponseMessage res = ctrl.Post(new FlagDTO());

      Assert.Equal(res.StatusCode, HttpStatusCode.OK);
    }

    /*[Fact]
    public void Test_SetAvailability() {
      var mock = new Mock<IDriverRepository>();
      mock.Setup(m => m.SetAvailability())
        .Returns(true);

      var ctrl = new DriverController(mock.Object);
      ctrl.Request = Substitute.For<HttpRequestMessage>();
      ctrl.Configuration = Substitute.For<HttpConfiguration>();
      HttpResponseMessage res = ctrl.Post();

      Assert.Equal(res.StatusCode, HttpStatusCode.OK);
    }*/
  }
}
