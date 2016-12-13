using Moq;
using NSubstitute;
using revashare_svc_webapi.Client.Controllers;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
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
        public void Test_AddDriver()
        { 
            var mock = new Mock<IAdminLogic>();

            mock.Setup(a => a.InsertDriver(new DriverDTO())).Returns(true);

            var ctrl = new AdminController(mock.Object);

            ctrl.Request = Substitute.For<HttpRequestMessage>();

            ctrl.Configuration = Substitute.For<HttpConfiguration>();

            HttpResponseMessage res = ctrl.AddDriver(new DriverDTO());

            Assert.Equal(res.StatusCode, HttpStatusCode.OK);
        }


    }
}
