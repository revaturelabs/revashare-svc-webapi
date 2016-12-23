using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.Mappers;
using revashare_svc_webapi.Logic.RevaShareServiceReference;

namespace revashare_svc_webapi.Logic.UserLogic
{
    public partial class UserLogic : IUser
    {
        private IServiceClient sc;
        public UserLogic(IServiceClient client)
        {
            sc = client;
        }

        public ApartmentDTO GetApartment(string name)
        {
            return ApartmentMapper.mapToApartmentDTO(sc.getApartmentByName(name));
        }

        public List<ApartmentDTO> GetApartments()
        {
            List<ApartmentDTO> apartments = new List<ApartmentDTO>();

            foreach (var apartment in sc.GetApartments())
            {
                apartments.Add(ApartmentMapper.mapToApartmentDTO(apartment));
            }

            return apartments;
        }

        public UserDTO GetUser(string UserName)
        {
            return UserMapper.mapToUserDTO(sc.GetUser(UserName));
        }

        public bool registerUser(UserDTO user, string password)
        {
            UserDAO userDao = UserMapper.mapToUserDAO(user);
            return sc.Register(userDao, user.UserName, password);
        }


        public UserDTO login(string userName, string password)
        {
            UserDAO user = sc.Login(userName, password);
            if (user == null)
            {
                return null;
            }
            return UserMapper.mapToUserDTO(user);
        }

    }
}
