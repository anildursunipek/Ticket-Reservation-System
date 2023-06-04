using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Repositories
{
    internal class TripRepository
    {

        public Trip AddTrip(Trip trip)
        {
            using (var db = new AppDbContext())
            {
                var savedTrip = db.Trips.Add(trip);
                db.SaveChanges();
                return savedTrip.Entity;
            }
        }

        public List<Trip> GetAllTrips()
        {

            using (var db = new AppDbContext())
            {
                var trips = db.Trips.ToList();

                foreach (var trip in trips)
                {
                    trip.StartingPoint = new LocationRepository().GetLocationById(trip.StartingPointId);
                    trip.DestinationPoint = new LocationRepository().GetLocationById(trip.DestinationPointId);
                    trip.Vehicle = new VehicleRepository().GetVehicleById(trip.VehicleId);
                }

                return trips;
            }
        }

        public List<Trip> getTripsByVehicle(int id)
        {
            return GetAllTrips().FindAll(trip => trip.VehicleId == id);
        }
        public Trip GetTripById(int id)
        {
            using (var db = new AppDbContext())
            {
                var trip = db.Trips.FirstOrDefault(v => v.Id == id);

                trip.StartingPoint = new LocationRepository().GetLocationById(trip.StartingPointId);
                trip.DestinationPoint = new LocationRepository().GetLocationById(trip.DestinationPointId);
                trip.Vehicle = new VehicleRepository().GetVehicleById(trip.VehicleId); 
                
                return trip;
            }
        }

        public void DeleteTrip(int id)
        {
            using (var db = new AppDbContext())
            {
                var Trip = db.Trips.FirstOrDefault(v => v.Id == id);
                if (Trip != null)
                {
                    db.Trips.Remove(Trip);
                    db.SaveChanges();
                }
            }
        }
    }
}
