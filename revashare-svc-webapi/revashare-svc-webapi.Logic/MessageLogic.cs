using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.Models;
using System.Net.Mail;

namespace revashare_svc_webapi.Logic {
  public class MessageLogic : IMessageRepository {
    public bool NotifyDropPassenger(RideDTO ride, UserDTO rider) {
      try {
        //TODO: Refactor this client setup
        SmtpClient client = new SmtpClient();
        client.Port = 25;
        client.Host = "smtp.gmail.com";
        client.Timeout = 5000;
        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        client.UseDefaultCredentials = false;
        client.EnableSsl = true;
        client.Credentials = new System.Net.NetworkCredential("sender@idk.com", "pw");

        MailMessage msg = new MailMessage("sender@idk.com", ride.Vehicle.Owner.Email);
        msg.Subject = rider.Name + "has dropped";
        msg.Body = ride.Vehicle.Owner.Name;

        client.Send(msg);
        return true;
      }
      catch (Exception) {
        return false;
      }
    }

    public bool NotifyInactiveDriver(RideDTO ride, UserDTO driver) {
      throw new NotImplementedException();
    }

    public bool NotifyNewPassenger(RideDTO ride, UserDTO rider) {
      throw new NotImplementedException();
    }

    public bool ResetPassword(UserDTO user) {
      throw new NotImplementedException();
    }
  }
}
