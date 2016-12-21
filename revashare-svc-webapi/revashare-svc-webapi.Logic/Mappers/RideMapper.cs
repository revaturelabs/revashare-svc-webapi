using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Mappers
{
    public class RideMapper
    {
        
        public static RideDTO mapToRideDTO(RideDAO b)
        {
            var a = new RideDTO();
            a.DepartureTime = b.DepartureTime;
            a.IsOnTime = b.IsOnTime;
            a.StartOfWeekDate = b.StartOfWeek;
            a.IsAMRide = b.IsAmRide;
            if (b.Vehicle != null)
            {
               a.Vehicle = VehicleMapper.mapToVehicleDTO(b.Vehicle);
            }            
            return a;
        }

        public static RideDAO mapToRideDAO(RideDTO b)
        {
            var a = new RideDAO();
            a.DepartureTime = b.DepartureTime;
            a.IsOnTime = b.IsOnTime;
            a.StartOfWeek = b.StartOfWeekDate;
            a.IsAmRide = b.IsAMRide;
            if(b.Vehicle!=null)
            {
               a.Vehicle = VehicleMapper.mapToVehicleDAO(b.Vehicle);
            }
            return a;
        }
        
    }
}
