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
    public List<FlagDTO> GetUserReports()
    {
      List<FlagDAO> allFlagsDAO = sc.GetFlags();
      List<FlagDTO> allFlagsDTO = new List<FlagDTO>();

      foreach (FlagDAO flag in allFlagsDAO)
      {
        allFlagsDTO.Add(FlagMapper.mapToFlagDTO(flag));
      }

      return allFlagsDTO;
    }

    public bool RemoveReport(FlagDTO reportToRemove)
    {

      throw new NotImplementedException();
      //return sc.DeleteFlag(FlagMapper.mapToFlagDAO(reportToRemove));
    }

    public bool RemoveDriverPrivileges(FlagDTO reportForUser)
    {
      throw new NotImplementedException();
    }
  }
}
