using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.ServiceClient
{
   public partial class ServiceClient:IServiceClient
   {
      RevaShareServiceReference sr = new RevaShareServiceReference();
      public bool deleteRide(ApartmentDAO apartment)
      {
         sr.DeleteRide(apartment);
      }

      public List<ApartmentDAO> GetApartments()
      {
         sr.GetApartments();
      }

      public bool InsertRide(ApartmentDAO apartment)
      {
         sr.INsertRide(apartment);
      }

      public bool UpdateApartment(ApartmentDAO apartment)
      {
         sr.UpdateApartment(apartment);
      }
   }
}
