using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic
{
    public class UserLogic
    {

        private static UserLogic logic = null;
        private IServiceClient client = null;

        private UserLogic()
        {
            
        }

        public static UserLogic getInstance()
        {
            if (logic == null)
            {
                logic = new UserLogic();
            }

            return logic;

        }

    }
}
