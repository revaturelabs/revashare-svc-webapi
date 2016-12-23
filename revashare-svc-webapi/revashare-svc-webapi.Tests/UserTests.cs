using revashare_svc_webapi.Logic.RevaShareServiceReference;
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

        private RevaShareDataServiceClient client;


        public UserTests()
        {
            this.client = new RevaShareDataServiceClient();
        }


        [Fact]
        public void test_getUsers()
        {
          
          List<UserDAO> getUsers = client.GetAllUsers().ToList();

          Assert.NotNull(getUsers);

        }

        [Fact]
        public void test_getUsersByUsername()
        {

          string name = "johnbob";
          UserDAO getUserByUsername = client.GetUserByUsername(name);

          Assert.NotNull(getUserByUsername);

        }



        [Fact]
        public void test_create_delete_user()
        {

            string sampleUserName = "not_gonna_remember_this_either";

            UserDAO new_user = new UserDAO()
            {
                Name = sampleUserName,
                UserName = sampleUserName,
                Apartment = new ApartmentDAO()
                {
                    Latitude = "1.1",
                    Longitude = "2.2",
                    Name = "abc"
                },
                Email = "asdf@g.com",
                PhoneNumber = "5556667777",
                Roles = new RoleDAO[] {
                    new RoleDAO()
                    {
                        Type = "Rider"
                    }
                }
            };

            bool success = client.RegisterUser(new_user, sampleUserName, "test_password");

            Assert.True(success);

            var user = client.GetUserByUsername(sampleUserName);

            Assert.NotNull(user);

            bool successDelete = client.DeleteUser(sampleUserName);

            Assert.True(successDelete);

            user = client.GetUserByUsername(sampleUserName);

            Assert.Null(user);

        }



        [Fact]
        public void test_deleteUser()
        {
            bool success = client.DeleteUser("bbbbb");

            Assert.True(success);
        }



        [Fact]
        public void test_login()
        {

            var user = client.Login("a_new_username", "sample_password");

            Assert.NotNull(user);

            user.UserName = "asdfqwer";
            bool success = client.RegisterUser(user, user.UserName, "a_totally_original_password");

            Assert.True(success);

        }


  }
}
