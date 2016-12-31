using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.Models;
using System.Net.Mail;

namespace revashare_svc_webapi.Logic
{
    public class MessageLogic : IMessageRepository
    {
   
        private static string MESSAGE_SUBJECT = "Revashare notification";
        private static string SENDER_USERNAME = "RevatureRevashare@gmail.com";
        private static string SENDER_PASSWORD = "Revature";


        public bool NotifyRiderUpgrade(UserDTO rider, bool success)
        {

            try
            {
                SmtpClient client = get_defaultClient();

                MailMessage msg = new MailMessage(SENDER_USERNAME, rider.Email);

                if (success)
                {
                    msg.Subject = "Revashare rider access granted";
                    msg.Body = "Congratulations, you are now a registered rider.";
                }
                else
                {
                    msg.Subject = "Revashare rider access rejected";
                    msg.Body = "Sorry, we could not verify your identity, please try contacting Revature for further support.";
                }
                client.Send(msg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            
            
        }

        public bool NotifyDriverUpgrade(UserDTO driver, bool success)
        {
            try
            {
                SmtpClient client = get_defaultClient();

                MailMessage msg = new MailMessage(SENDER_USERNAME, driver.Email);

                if (success)
                {
                    msg.Subject = "Revashare driver access granted";
                    msg.Body = "Congratulations, you are now a registered driver.";
                }
                else
                {
                    msg.Subject = "Revashare driver access rejected";
                    msg.Body = "Sorry, we could not verify car registration, please try contacting Revature for further support.";
                }
                client.Send(msg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool NotifyDropPassenger(RideDTO ride, UserDTO rider)
        {
            try
            {
                //TODO: Refactor this client setup
                SmtpClient client = get_defaultClient();

                MailMessage msg = new MailMessage(SENDER_USERNAME, "david115632042@gmail.com");
                msg.Subject = MESSAGE_SUBJECT;
                msg.Body = "this is a message";

                client.Send(msg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool NotifyInactiveDriver(RideDTO ride, UserDTO driver)
        {
            throw new NotImplementedException();
        }

        public bool NotifyNewPassenger(RideDTO ride, UserDTO rider)
        {
            throw new NotImplementedException();
        }

        public bool ResetPassword(UserDTO user)
        {
            throw new NotImplementedException();
        }


        private static SmtpClient get_defaultClient()
        {
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.Host = "smtp.gmail.com";
            client.Timeout = 5000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential(SENDER_USERNAME, SENDER_PASSWORD);
            return client;
        }

    }
}
