using revashare_svc_webapi.Logic.AdminLogic;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using revashare_svc_webapi.Logic.ServiceClient;
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
    [Fact]
    public void test_getRides()
    {
      RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();

      List<RideDAO> getRides = dataClient.GetAllRides().ToList();

      Assert.NotNull(getRides);

    }


  }
}
