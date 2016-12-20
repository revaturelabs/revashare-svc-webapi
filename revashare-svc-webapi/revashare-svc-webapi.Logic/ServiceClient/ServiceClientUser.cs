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
         return rs.DeleteUser(user.Name);
      }

      public List<UserDAO> GetUsers()
      {
         //return rs.getusers();
         throw new NotImplementedException();
      }
      public bool UpdateUser(UserDAO user)
      {
         return rs.UpdateUser(user);
      }
      public bool RequestToBeDriver(string user)
      {
         return rs.RequestToBeDriver(user);
      }
      public bool Login(string UserName, string Password)
      {
        return rs.Login(UserName, Password);
      }
      public bool Register(UserDAO user, string UserName, string Password)
      {
         return rs.RegisterUser(user, UserName, Password);
      }
      //public bool UpdateUserRole(string UserName, string role)
      //{
      //   return rs.UpdateUserRole(UserName, role);
      //}
      public bool AproveDriver(string UserName)
      {
         return rs.ApproveDriver(UserName);
      }
      public bool AproveUser(string UserName)
      {
         return rs.ApproveUser(UserName);
      }
      public List<UserDAO> PendingRegistrations()
      {
         return rs.PendingRegistrations().ToList();
      }
      public List<UserDAO> PendingDriverAprovals()
      {
         return rs.PendingDriverApprovals().ToList();
      }
   }
}
