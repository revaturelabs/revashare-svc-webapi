using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.RiderLogic
{
   public partial class RiderLogic : IRider
   {
      public List<UserDTO> getUsers()
      {
         var list = sc.GetUsers();
         var ret = new List<UserDTO>();
         foreach (var item in list)
         {
            ret.Add(Mappers.UserMapper.mapToUserDTO(item));
         }
         return ret;
      }



      public bool modifyUserInfo(UserDTO user)
      {
         return sc.UpdateUser(Mappers.UserMapper.mapToUserDAO(user));
      }
   }
}
