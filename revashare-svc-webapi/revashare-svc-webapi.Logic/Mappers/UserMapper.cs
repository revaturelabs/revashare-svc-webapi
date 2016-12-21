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
         if(b.Apartment!=null)
         {
            a.Apartment =ApartmentMapper.mapToApartmentDTO(b.Apartment);
         }         
         a.Email = b.Email;
         a.Name = b.Name;
         a.PhoneNumber = b.PhoneNumber;
         a.Roles = new List<RoleDTO>();
         if(b.Roles!=null)
         {
            foreach (var item in b.Roles)
            {
               a.Roles.Add(RoleMapper.mapToRoleDTO(item));
            }
         }        
         a.UserName = b.UserName;               
         return a;
      }

      public static UserDAO mapToUserDAO(UserDTO b)
      {
         var a = new UserDAO();
         if(b.Apartment!=null)
         {
            a.Apartment = ApartmentMapper.mapToApartmentDAO(b.Apartment);
         }         
         a.Email = b.Email;
         a.Name = b.Name;
         a.PhoneNumber = b.PhoneNumber;
         a.Roles = new RoleDAO[3];
         if (b.Roles != null)
         {
            for (int i = 0; i < b.Roles.Count; i++)
            {
               a.Roles[i] = RoleMapper.mapToRoleDAO(b.Roles[i]);
            }
         }
         a.UserName = b.UserName;  
         return a;
      }
   }
}
