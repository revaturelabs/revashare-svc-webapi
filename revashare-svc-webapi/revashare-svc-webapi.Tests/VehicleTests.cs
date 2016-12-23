using revashare_svc_webapi.Logic.AdminLogic;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using revashare_svc_webapi.Logic.RiderLogic;
using revashare_svc_webapi.Logic.ServiceClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
  }
}
