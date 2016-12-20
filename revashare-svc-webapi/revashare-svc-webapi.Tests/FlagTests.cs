using revashare_svc_webapi.Logic;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
      AdminLogic admLogic = new AdminLogic();
      var a = admLogic.GetUserReports();
         

      Assert.NotEmpty(a);

    }

    //[Fact]
    //public void test_RemoveReport_AdminLogic()
    //{
    //  AdminLogic admLogic = new AdminLogic();



    //}



  }
}
