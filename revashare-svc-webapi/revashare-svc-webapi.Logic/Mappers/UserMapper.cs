using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Mappers
{
   public class UserMapper
   {
      public static UserDTO mapToUserDTO(UserDAO b)
      {
         var a = new UserDTO();
         a.Apartment =ApartmentMapper.mapToApartmentDTO(b.Apartment);
         a.Email = b.Email;
         a.Name = b.Name;
         a.PhoneNumber = b.PhoneNumber;         
         return a;
      }

      public static UserDAO mapToUserDAO(UserDTO b)
      {
         var a = new UserDAO();
         a.Apartment = ApartmentMapper.mapToApartmentDAO(b.Apartment);
         a.Email = b.Email;
         a.Name = b.Name;
         a.PhoneNumber = b.PhoneNumber;

         return a;
      }
   }
}
