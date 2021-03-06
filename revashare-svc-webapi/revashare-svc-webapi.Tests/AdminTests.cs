﻿using Moq;
using NSubstitute;
using revashare_svc_webapi.Client.Controllers;
using revashare_svc_webapi.Logic;
using revashare_svc_webapi.Logic.AdminLogic;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using revashare_svc_webapi.Logic.ServiceClient;
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
    public void test_GetAdmins()
    {
      RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();

      List<UserDAO> getAdmins = dataClient.GetAdmins().ToList();

      Assert.NotNull(getAdmins);

    }

    [Fact]
    public void Test_WCF_GetUserReports()
    {
      RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();
      RoleDAO[] roles = new RoleDAO[3];
      RoleDAO newRole = new RoleDAO();
      newRole.Type = "Rider";
      roles[0] = newRole;
      FlagDAO newFlag = new FlagDAO()
      {
        Driver = new UserDAO { Name = "ray", Apartment = new ApartmentDAO { Name = "apt", Latitude = "1.1", Longitude = "2.2" }, Email = "ray@gmail.com", PhoneNumber = "747-231-7281", Roles = roles, UserName = "Ray" },
        FlagID = 2,
        Message = "Flag message",
        Type = "flagType",
        Rider = new UserDAO { Name = "raydriver", Apartment = new ApartmentDAO { Name = "apt2", Latitude = "1.3", Longitude = "2.2" }, Email = "ray@gmail.com", PhoneNumber = "747-231-7281", Roles = roles, UserName = "Ray" }
      };

      dataClient.CreateFlag(newFlag);

      List<FlagDAO> acquiredFlags = dataClient.GetAllFlags().ToList();

      Assert.NotNull(acquiredFlags);
    }

    [Fact]
    public void AddAdminDeleteUser_Test()
    {
      RevaShareDataServiceClient svc = new RevaShareDataServiceClient();

      UserDAO testUser = new UserDAO { Name = "ray admin", UserName = "rayadmin", Email = "rayadmin@gmail.com", PhoneNumber = "422-283-2816", Apartment = null };
      bool resultAddAdmin = svc.AddAdmin(testUser, "rayadmin", "ray2123");
      bool resultDeleteUser = svc.DeleteUser("rayadmin");

      Assert.True(resultAddAdmin && resultDeleteUser);
    }


    [Fact]
    public void test_approveRider()
    {
      RevaShareDataServiceClient svc = new RevaShareDataServiceClient();

      bool success = svc.ApproveRider("not_gonna_remember_this");

      Assert.True(success);

    }

  }
}
