using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.ServiceClient
{
   public partial class ServiceClient//:IServiceClient
   {
      RevaShareDataServiceClient rs = new RevaShareDataServiceClient();
      //public bool deleteRide(ApartmentDAO apartment)
      //{
      //   return rs.DeleteRide(apartment);
      //}

      //public List<ApartmentDAO> GetApartments()
      //{
      //   return rs.GetApartments();
      //}

      //public bool InsertRide(ApartmentDAO apartment)
      //{
      //   return rs.InsertRide(apartment);
      //}

      //public bool UpdateApartment(ApartmentDAO apartment)
      //{
      //   return rs.UpdateApartment(apartment);
      //}
   }
}
