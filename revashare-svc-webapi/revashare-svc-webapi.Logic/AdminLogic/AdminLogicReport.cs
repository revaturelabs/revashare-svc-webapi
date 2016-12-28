using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Mappers;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.AdminLogic
{
    public partial class AdminLogic : IAdmin
    {
        public List<FlagDTO> GetUserReports(UserDTO user)
        {
            List<FlagDTO> userFlags = new List<FlagDTO>();

            foreach (var flag in sc.GetFlags())
            {
                if(flag.Driver.UserName == user.UserName)
                {
                    userFlags.Add(FlagMapper.mapToFlagDTO(flag));
                }
            }

            return userFlags;
        }

        public FlagDTO GetReport(int id)
        {
            return FlagMapper.mapToFlagDTO(sc.GetFlagsById(id));
        }

        public List<FlagDTO> GetReports()
        {
            List<FlagDTO> flags = new List<FlagDTO>();

            foreach (var flag in sc.GetFlags())
            {
                flags.Add(FlagMapper.mapToFlagDTO(flag));
            }
            return flags;
        }

        public bool RemoveReport(FlagDTO reportToRemove)
        {
            return sc.DeleteFlag(FlagMapper.mapToFlagDAO(reportToRemove));
        }

        public bool RemoveDriverPrivileges(UserDTO user)
        {
            return sc.AproveUser(user.UserName);
        }
    }
}
