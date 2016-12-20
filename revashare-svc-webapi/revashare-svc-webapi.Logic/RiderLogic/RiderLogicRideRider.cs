﻿using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.RiderLogic
{
   public partial class RiderLogic : IRider
   {
      public bool addRiderToRide(RideDTO ride, UserDTO rider)
      {         
         return sc.InsertRideRider(Mappers.UserMapper.mapToUserDAO(rider), Mappers.RideMapper.mapToRideDAO(ride));
      }

      public bool removeRiderFromRide(UserDTO rider, RideDTO ride)
      {
         return sc.InsertRideRider(Mappers.UserMapper.mapToUserDAO(rider), Mappers.RideMapper.mapToRideDAO(ride));
      }

      public List<RideRiderDTO> getRideRidersByUser(UserDTO rider)
      {
         var list = sc.GetRideRiders().Where(m => m.Rider.Name.Equals(rider.Name));
         var ret = new List<RideRiderDTO>();
         foreach (var item in list)
         {
            ret.Add(Mappers.RideRiderMapper.mapToRideRiderDTO(item));
         }
         return ret;
      }

      public List<RideRiderDTO> getRideRiders()
      {
         var list = sc.GetRideRiders();
         var ret = new List<RideRiderDTO>();
         if (list != null)
         {
            foreach (var item in list)
            {
               ret.Add(Mappers.RideRiderMapper.mapToRideRiderDTO(item));
            }           
         }
         return ret;
      }
      public List<UserDTO> GetRidersByRide(RideDTO ride)
      {
         var rr = getRideRiders().Where(m => m.Ride.Vehicle.LicensePlate.Equals(ride.Vehicle.LicensePlate));
         var riders = new List<UserDTO>();
         foreach (var item in rr)
         {
            riders.Add(item.Rider);
         }
         return riders;
      }
      public int getOccupiedSeatsByRide(RideDTO ride)
      {
         var rr = getRideRiders().Where(m => m.Ride.Vehicle.LicensePlate.Equals(ride.Vehicle.LicensePlate)).ToList();
         var occupied = rr.Count;
         return occupied;
      }
   }
}