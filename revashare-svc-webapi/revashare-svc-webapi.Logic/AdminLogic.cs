using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using revashare_svc_webapi.Logic.Mappers;

namespace revashare_svc_webapi.Logic
{
    public class AdminLogic : IAdminLogic
    {
        private RevaShareDataServiceClient dataClient = new RevaShareDataServiceClient();

        #region Admin CRUD Methods
        public bool InsertAdmin(UserDTO adminToAdd)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> RequestAdmins()
        {
            throw new NotImplementedException();
        }

        public bool ModifyAdmin(UserDTO adminToUpdate)
        {
            var updataUser = UserMapper.mapToUserDAO(adminToUpdate);

            return dataClient.UpdateUser(updataUser);
        }

        public bool DeleteAdmin(UserDTO adminToRemove)
        {
            return dataClient.DeleteUser(adminToRemove.UserName);
        }
        #endregion

        #region Driver CRUD Methods
        public bool InsertDriver(UserDTO driverToAdd)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> RequestDrivers()
        {
            return new List<UserDTO>();
        }

        public bool ModifyDriver(UserDTO driverToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDriver(UserDTO driverToRemove)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Rider CRUD Methods
        public bool InsertRider(UserDTO riderToAdd)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> RequestRiders()
        {
            throw new NotImplementedException();
        }

        public bool ModifyRider(UserDTO riderToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRider(UserDTO riderToRemove)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region User Approval
        public bool ApproveUser(UserDTO userToApprove)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> GetPendingRiders()
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> GetPendingDrivers()
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> GetPendingAdmins()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region User Reporting
        public List<FlagDTO> GetUserReports()
        {
            List<FlagDAO> allFlagsDAO = dataClient.GetAllFlags().ToList();
            List<FlagDTO> allFlagsDTO = new List<FlagDTO>();
            FlagDTO temp = new FlagDTO();

            foreach (FlagDAO flag in allFlagsDAO)
            {
                temp = FlagMapper.mapToFlagDTO(flag);
                allFlagsDTO.Add(temp);
            }

            return allFlagsDTO;
        }

        public bool RemoveReport(FlagDTO reportToRemove)
        {
            throw new NotImplementedException();
        }

        public bool RemoveDriverPrivileges(FlagDTO reportForUser)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
