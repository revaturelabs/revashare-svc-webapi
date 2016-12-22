using revashare_svc_webapi.Logic.RevaShareServiceReference;
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

  }
}
