using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Xunit;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using revashare_svc_webapi.Client.Controllers;
using revashare_svc_webapi.Logic.RiderLogic;

namespace revashare_svc_webapi.Tests
{
  public class RiderTests
  {
    [Fact]
    public void testGetRides_takesString_returnsListOfRides()
    {
      //Arrange
      Mock<IServiceClient> MockSC = new Mock<IServiceClient>();
      var list = new List<RideDAO>();
      RoleDAO[] roles = new RoleDAO[3];
      roles[0] = new RoleDAO() { Type = "driver" };
      var a = new ApartmentDAO() { Name = "test apartment" };
      var o = new UserDAO() { Email = "a@b.c", Name = "john doe", PhoneNumber = "1234567890", Apartment = a, Roles = roles, UserName = "test owner" };

      var v = new VehicleDAO() { Capacity = 4, Color = "blue", LicensePlate = "testplate", Make = "subaru", Model = "Forester", Owner = o };

      var r = new RideDAO() { Vehicle = v };
      list.Add(r);

      MockSC.Setup(m => m.getRidesByLocation(It.IsAny<string>())).Returns(list);

      var ctrl = new RiderController(new RiderLogic(MockSC.Object));
      //Act
      var actual = ctrl.GetRides("test");
      //Assert

      Assert.NotNull(actual);
    }
  }
}
