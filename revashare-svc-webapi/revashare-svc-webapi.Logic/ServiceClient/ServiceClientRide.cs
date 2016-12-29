using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.ServiceClient
{
  public partial class ServiceClient : IServiceClient
  {

    public bool DeleteRide(RideDAO ride)
    {

      return rs.DeleteRide(ride);
    }

    public List<RideDAO> GetRides()
    {
      return rs.GetAllRides().ToList();

    }

    public bool InsertRide(RideDAO ride)
    {
      return rs.AddRide(ride);
    }

    public bool UpdateRide(RideDAO ride)
    {
      return rs.UpdateRide(ride);
    }

    public List<RideDAO> getRidesByLocation(string name)
    {
      return rs.ListRidesAtApartment(name).ToList();
    }

    public int getAvailableSeatsByRide(RideDAO ride)
    {
      //return rs.getAvailableSeatsByRide(ride);
      throw new NotImplementedException();
    }

    public List<RideDAO> GetRidesByApartment(string name)
    {
      return rs.ListRidesAtApartment(name).ToList();
    }

    public List<RideDAO> GetMorningRidesByApartment(string name)
    {
      return rs.ListRidesAtApartmentAM(name).ToList();
    }

    public List<RideDAO> GetEveningRidesByApartment(string name)
    {
      return rs.ListRidesAtApartmentPM(name).ToList();
    }

  }
}
