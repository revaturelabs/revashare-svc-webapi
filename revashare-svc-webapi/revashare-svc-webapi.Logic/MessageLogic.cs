using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.Models;

namespace revashare_svc_webapi.Logic {
  public class MessageLogic : IMessageRepository {
    public bool NotifyDropPassenger(RideDTO ride, UserDTO rider) {
      throw new NotImplementedException();
    }

    public bool NotifyNewPassenger(RideDTO ride, UserDTO rider) {
      throw new NotImplementedException();
    }
  }
}
