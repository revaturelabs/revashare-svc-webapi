using revashare_svc_webapi.Logic.Models;
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
  public class ApartmentTests
  {
    [Fact]
    public void test_getApartments()
    {
      RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();

      List<ApartmentDAO> getApartments = dataClient.ListApartments().ToList();

      Assert.NotNull(getApartments);

    }

    [Fact]
    public void test_getApartmentByName()
    {
      RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();
      
      string name = "abc";
      ApartmentDAO getApartmentByName = dataClient.GetApartmentByName(name);

      Assert.NotNull(getApartmentByName);

    }

    [Fact]
    public void test_GetApartments_RiderLogic()
    {
      ServiceClient sc = new ServiceClient();
      RiderLogic rdrLogic = new RiderLogic(sc);
      var a = rdrLogic.getApartments();


      Assert.NotEmpty(a);

    }
    /*
    [Fact]
    public void test_GetApartmentByName_RiderLogic()
    {
      ServiceClient sc = new ServiceClient();
      RiderLogic rdrLogic = new RiderLogic(sc);
      var name = "abc";
      
      var a = rdrLogic.getApartmentByName(name);


      Assert.NotEmpty(a);

    }
    */

  }
}
