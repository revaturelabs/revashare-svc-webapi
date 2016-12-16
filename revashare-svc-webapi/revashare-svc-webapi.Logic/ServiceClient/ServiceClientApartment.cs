using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.ServiceClient
{
   public partial class ServiceClient:IServiceClient
   {
      RevaShareDataServiceClient rs = new RevaShareDataServiceClient();
      public bool DeleteApartment(ApartmentDAO apartment)
      {
         return rs.DeleteApartment(apartment.Name);
      }

      public List<ApartmentDAO> GetApartments()
      {
         return rs.ListApartments().ToList();
      }
      public ApartmentDAO getApartmentByName(string name)
      {
         return rs.GetApartmentByName(name);
      }

      public bool InsertApartment(ApartmentDAO apartment)
      {
         return rs.AddApartment(apartment);
      }

      public bool UpdateApartment(ApartmentDAO apartment)
      {
         return rs.UpdateApartment(apartment);
      }
   }
}
