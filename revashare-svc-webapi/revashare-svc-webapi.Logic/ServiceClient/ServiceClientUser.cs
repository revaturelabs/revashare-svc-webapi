using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.ServiceClient
{
   public partial class ServiceClient:IServiceClient
   {
      public bool DeleteUser(UserDAO user)
      {
         //return rs.deleteUser(ride);
         throw new NotImplementedException();
      }

      public List<UserDAO> GetUsers()
      {
         //return rs.GetUsers();
         throw new NotImplementedException();
      }

      public bool InsertUser(UserDAO user)
      {
         //return rs.InsertUser(ride);
         throw new NotImplementedException();
      }

      public bool UpdateUser(UserDAO user)
      {
         //return rs.UpdateUser(user);
         throw new NotImplementedException();
      }

      public bool RequestToBeDriver(UserDAO user)
      {
         //return rs.RequestToBeDriver(user);
         throw new NotImplementedException();
      }
   }
}
