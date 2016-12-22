using Moq;
using NSubstitute;
using revashare_svc_webapi.Client.Controllers;
using revashare_svc_webapi.Logic;
using revashare_svc_webapi.Logic.AdminLogic;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using revashare_svc_webapi.Logic.ServiceClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Xunit;

namespace revashare_svc_webapi.Tests
{
  public class AdminTests
  {

    //[Fact]
    //public void Test_AddDriver_AdminController()
    //{
    //  var mock = new Mock<IAdmin>();
    //  mock.Setup(a => a.InsertDriver(new UserDTO())).Returns(true);
    //  var ctrl = new AdminController(mock.Object);

    //  ctrl.Request = Substitute.For<HttpRequestMessage>();
    //  ctrl.Configuration = Substitute.For<HttpConfiguration>();
    //  HttpResponseMessage res = ctrl.AddDriver(new UserDTO());

    //  Assert.Equal(res.StatusCode, HttpStatusCode.OK);
    //}

    [Fact]
    public void Test_WCF_GetUserReports()
    {
      RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();
      RoleDAO[] roles = new RoleDAO[3];
      RoleDAO newRole = new RoleDAO();
      newRole.Type = "Rider";
      roles[0] = newRole;
      FlagDAO newFlag = new FlagDAO()
      {
        Driver = new UserDAO { Name = "ray", Apartment = new ApartmentDAO { Name = "apt", Latitude = "1.1", Longitude = "2.2" }, Email = "ray@gmail.com", PhoneNumber = "747-231-7281", Roles = roles, UserName = "Ray" },
        FlagID = 2,
        Message = "Flag message",
        Type = "flagType",
        Rider = new UserDAO { Name = "raydriver", Apartment = new ApartmentDAO { Name = "apt2", Latitude = "1.3", Longitude = "2.2" }, Email = "ray@gmail.com", PhoneNumber = "747-231-7281", Roles = roles, UserName = "Ray" }
      };

      dataClient.CreateFlag(newFlag);

      List<FlagDAO> acquiredFlags = dataClient.GetAllFlags().ToList();

      Assert.NotNull(acquiredFlags);
    }

  }
}
