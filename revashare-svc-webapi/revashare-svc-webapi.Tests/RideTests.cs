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
    

  }
}
