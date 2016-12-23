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
  public class UserTests
  {
    [Fact]
    public void test_getUsers()
    {
      RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();

      List<UserDAO> getUsers = dataClient.GetAllUsers().ToList();

      Assert.NotNull(getUsers);

    }

    [Fact]
    public void test_getUsersByUsername()
    {
      RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();

      string name = "johnbob";
      UserDAO getUserByUsername = dataClient.GetUserByUsername(name);

      Assert.NotNull(getUserByUsername);

    }

    //[Fact]
    //public void test_GetUsers_RiderLogic()
    //{
    //  ServiceClient sc = new ServiceClient();
    //  RiderLogic rdrLogic = new RiderLogic(sc);
    //  var a = rdrLogic.getUsers();

    //  Assert.NotEmpty(a);

    //}

  }
}
