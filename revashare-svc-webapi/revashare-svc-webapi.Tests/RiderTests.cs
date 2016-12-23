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
    public void test_GetRides()
    {
      RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();

      List<RideDAO> getRide = dataClient.GetAllRides().ToList();

      Assert.NotNull(getRide);

    }
    
  }
}
