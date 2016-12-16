using Moq;
using NSubstitute;
using revashare_svc_webapi.Client.Controllers;
using revashare_svc_webapi.Logic;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
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
        [Fact]
        public void Test_AddDriver_AdminController()
        {
            var mock = new Mock<IAdminLogic>();
            mock.Setup(a => a.InsertDriver(new UserDTO())).Returns(true);
            var ctrl = new AdminController(mock.Object);

            ctrl.Request = Substitute.For<HttpRequestMessage>();
            ctrl.Configuration = Substitute.For<HttpConfiguration>();
            HttpResponseMessage res = ctrl.AddDriver(new UserDTO());

            Assert.Equal(res.StatusCode, HttpStatusCode.OK);
        }

        [Fact]
        public void Test_AddDriver_AdminLogic()
        {
            AdminLogic admLogic = new AdminLogic();
            UserDTO testDriver = new UserDTO { Name = "TestDriver2" };

            bool actual = admLogic.InsertDriver(testDriver);

            Assert.True(actual);
        }

        [Fact]
        public void Test_WCF_GetUserReports()
        {
            RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();

            List<FlagDAO> acquiredFlags = dataClient.GetAllFlags().ToList();

            Assert.NotNull(acquiredFlags);
        }

    }
}
