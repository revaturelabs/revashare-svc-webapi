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

        RevaShareDataServiceClient rs;

        public ServiceClient()
        {
            this.rs = new RevaShareDataServiceClient();
        }

    }
}
