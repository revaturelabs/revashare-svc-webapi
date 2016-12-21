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
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Xunit;

namespace revashare_svc_webapi.Tests
{

  public class FlagTests
  {
    [Fact]
    public void test_GetFlags()
    {
      RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();

      List<FlagDAO> getflags = dataClient.GetAllFlags().ToList();

      Assert.NotNull(getflags);

    }


    [Fact]
    public void test_GetFlags_AdminLogic()
    {
      ServiceClient sc = new ServiceClient();
      AdminLogic admLogic = new AdminLogic(sc);
      var a = admLogic.GetUserReports();


      Assert.NotEmpty(a);

    }


    [Fact]
    public void test_RemoveReport_AdminController()
    {
      var mock = new Mock<IAdmin>();
      mock.Setup(a => a.RemoveReport(new FlagDTO())).Returns(true);
      var ctrl = new AdminController(mock.Object);

      ctrl.Request = Substitute.For<HttpRequestMessage>();
      ctrl.Configuration = Substitute.For<HttpConfiguration>();
      HttpResponseMessage res = ctrl.RemoveReport(new FlagDTO());

      Assert.Equal(res.StatusCode, HttpStatusCode.OK);

      }


    }
  }
