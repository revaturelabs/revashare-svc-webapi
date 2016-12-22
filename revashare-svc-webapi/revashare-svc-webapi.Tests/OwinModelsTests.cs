using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using revashare_svc_webapi.Client.Models.OwinModels;
using System.Security.Claims;
using Newtonsoft.Json;

namespace revashare_svc_webapi.Tests
{
    public class OwinModelsTests
    {

        [Fact]
        public void test_userSerialization()
        {

            Logic.Models.UserDTO userDTO = new Logic.Models.UserDTO()
            {
                Name = "sample name",
                Apartment = new Logic.Models.ApartmentDTO()
                {
                    Latitude = "123",
                    Longitude = "3234",
                    Name = "sample name"
                },
                ApartmentId = 243,
                Email = "sample email",
                PhoneNumber = "sample phone number",
                Roles = new List<Logic.Models.RoleDTO>()
                {
                    new Logic.Models.RoleDTO()
                    {
                        Type = "user"
                    }
                },
                UserName = "sample username"
            };

            string userJson = JsonConvert.SerializeObject(userDTO);

            ClaimsIdentity identity = new ClaimsIdentity();
            identity.AddClaims(new Claim[]
            {
                new Claim(ClaimTypes.Role, "user"),
                new Claim(ClaimTypes.UserData, userJson)
            });

            ClaimsPrincipal principal = new ClaimsPrincipal(identity);
            User user = new User(principal);

            Assert.Equal(user.getUserDetails().Name, userDTO.Name);

        }

    }
}
