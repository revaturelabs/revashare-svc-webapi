using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Interfaces {
  public interface IMessageRepository {
    bool NotifyNewPassenger(RideDTO ride, UserDTO rider);

    bool NotifyDropPassenger(RideDTO ride, UserDTO rider);

    bool NotifyInactiveDriver(RideDTO ride, UserDTO driver);

    bool ResetPassword(UserDTO user);
  }
}
