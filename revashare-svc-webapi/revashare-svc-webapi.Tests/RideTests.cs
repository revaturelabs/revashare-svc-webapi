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
    public class RideTests
    {

        private RiderLogic riderLogic;
        private DriverLogic driverLogic;

        public RideTests()
        {
            ServiceClient svc = new ServiceClient();

            this.riderLogic = new RiderLogic(svc);
            this.driverLogic = new DriverLogic();
        }

    [Fact]
    public void test_getRidesByApartments()
    {
      RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();
      var name = "abc";
      List<RideDAO> getRides = dataClient.ListRidesAtApartment(name).ToList();

      Assert.NotNull(getRides);

    }


    [Fact]
    public void test_GetRides_RiderLogic()
    {
      ServiceClient sc = new ServiceClient();
      RiderLogic rdrLogic = new RiderLogic(sc);
      var a = rdrLogic.getRides();


      Assert.NotEmpty(a);

    }

    
    #region Mock Tests 


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

    [Fact]
    public void Test_CancelRide()
    {
      var mock = new Mock<IDriverRepository>();
      mock.Setup(m => m.CancelRide(new RideDTO()));


      var ctrl = new DriverController(mock.Object);
      ctrl.Request = Substitute.For<HttpRequestMessage>();
      ctrl.Configuration = Substitute.For<HttpConfiguration>();
      HttpResponseMessage res = ctrl.CancelRide(new RideDTO());

      Assert.Equal(res.StatusCode, HttpStatusCode.OK);
    }

    [Fact]
    public void Test_ScheduleRide()
    {
      var mock = new Mock<IDriverRepository>();
      mock.Setup(m => m.ScheduleRide(new RideDTO()));


      var ctrl = new DriverController(mock.Object);
      ctrl.Request = Substitute.For<HttpRequestMessage>();
      ctrl.Configuration = Substitute.For<HttpConfiguration>();
      HttpResponseMessage res = ctrl.ScheduleRide(new RideDTO());

      Assert.Equal(res.StatusCode, HttpStatusCode.OK);
    }

    [Fact]
    public void Test_SetAvailability()
    {
      var mock = new Mock<IDriverRepository>();
      mock.Setup(m => m.SetAvailability(new RideDTO()));


      var ctrl = new DriverController(mock.Object);
      ctrl.Request = Substitute.For<HttpRequestMessage>();
      ctrl.Configuration = Substitute.For<HttpConfiguration>();
      HttpResponseMessage res = ctrl.SetAvailability(new RideDTO());

      Assert.Equal(res.StatusCode, HttpStatusCode.OK);
    }

    /*    Doesn't have a getSingleRide function within DriverController. There is one within the DriverLogic
    [Fact]
    public void Test_GetSingleRide()
    {
      var mock = new Mock<IDriverRepository>();
      mock.Setup(m => m.getSingleRide(new RideDTO()));


      var ctrl = new DriverController(mock.Object);
      ctrl.Request = Substitute.For<HttpRequestMessage>();
      ctrl.Configuration = Substitute.For<HttpConfiguration>();
      HttpResponseMessage res = ctrl.(new RideDTO());

      Assert.Equal(res.StatusCode, HttpStatusCode.OK);
    }
    */


    #endregion
  }
}
