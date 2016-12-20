using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.AdminLogic
{
    public partial class AdminLogic : IAdmin
    {
        public List<FlagDTO> GetUserReports()
        {
            throw new NotImplementedException();
        }

        public bool RemoveReport(FlagDTO reportToRemove)
        {
            throw new NotImplementedException();
        }

        public bool RemoveDriverPrivileges(FlagDTO reportForUser)
        {
            throw new NotImplementedException();
        }
    }
}
