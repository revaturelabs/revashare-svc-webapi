using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.ServiceClient
{
    public partial class ServiceClient
    {

        private RevaShareDataServiceClient rs;
        private static ServiceClient client;

        private ServiceClient()
        {
            this.rs = new RevaShareDataServiceClient();
        }

        public static ServiceClient getClient()
        {
            if (client == null)
            {
                client = new ServiceClient();
            }

            return client;

        }

    }
}
