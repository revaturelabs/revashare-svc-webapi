using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.ModelDTO;
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
            return true;
        }

        public List<UserDTO> RequestAdmins()
        {
            return new List<UserDTO>();
        }

        public bool ModifyAdmin(UserDTO adminToUpdate)
        {
            return true;
        }

        public bool DeleteAdmin(UserDTO adminToRemove)
        {
            return true;
        }
        #endregion

        #region Driver CRUD Methods
        public bool InsertDriver(UserDTO driverToAdd)
        {
            return true;
        }

        public List<UserDTO> RequestDrivers()
        {
            return new List<UserDTO>();
        }

        public bool ModifyDriver(UserDTO driverToUpdate)
        {
            return true;
        }

        public bool DeleteDriver(UserDTO driverToRemove)
        {
            return true;
        }
        #endregion

        #region Rider CRUD Methods
        public bool InsertRider(UserDTO riderToAdd)
        {
            return true;
        }

        public List<UserDTO> RequestRiders()
        {
            return new List<UserDTO>();
        }

        public bool ModifyRider(UserDTO riderToUpdate)
        {
            return true;
        }

        public bool DeleteRider(UserDTO riderToRemove)
        {
            return true;
        }
        #endregion

        #region User Approval
        public bool ApproveUser(UserDTO userToApprove)
        {
            return true;
        }

        public List<UserDTO> GetPendingRiders()
        {
            return new List<UserDTO>();
        }

        public List<UserDTO> GetPendingDrivers()
        {
            return new List<UserDTO>();
        }

        public List<UserDTO> GetPendingAdmins()
        {
            return new List<UserDTO>();
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
            return true;
        }

        public bool RemoveDriverPrivileges(FlagDTO reportForUser)
        {
            return true;
        }
        #endregion
    }
}
