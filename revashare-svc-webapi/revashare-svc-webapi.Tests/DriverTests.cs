using Moq;
using NSubstitute;
using revashare_svc_webapi.Client.Controllers;
using revashare_svc_webapi.Logic;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.ModelDTO;
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
      HttpResponseMessage res = ctrl.UpdateVehicleInfo(new VehicleDTO());
   
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
      HttpResponseMessage res = ctrl.ReportRider(new FlagDTO());

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

    //[Fact]
    //public void Test_AddDriver_AdminController() {
    //  var mock = new Mock<IDriverRepository>();
    //  mock.Setup(a => a.InsertDriver(new UserDTO())).Returns(true);
    //  var ctrl = new DriverController(mock.Object);

    //  ctrl.Request = Substitute.For<HttpRequestMessage>();
    //  ctrl.Configuration = Substitute.For<HttpConfiguration>();
    //  HttpResponseMessage res = ctrl.AddDriver(new UserDTO());

    //  Assert.Equal(res.StatusCode, HttpStatusCode.OK);
    //}

    //[Fact]
    //public void Test_AddDriver_AdminLogic() {
    //  DriverLogic admLogic = new DriverLogic();
    //  UserDTO testDriver = new UserDTO {
    //    Name = "TestName",
    //    Apartment = new ApartmentDTO { Id = "1", Latitude = "1.11", Longitude = "2.22", Name = "Camden Dulles" },
    //    Email = "test@gmail.com",
    //    PhoneNumber = "123-456-7891"
    //  };


    //  bool actual = admLogic.InsertDriver(testDriver);

    //  Assert.True(actual);
    //}


  }
}
