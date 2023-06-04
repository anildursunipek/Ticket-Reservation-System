using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Repositories
{
    internal class LocationRepository
    {

        public void AddLocation(Location location)
        {
            using (var db = new AppDbContext())
            {
                db.Locations.Add(location);
                db.SaveChanges();
            }
        }

        public List<Location> GetAllLocations()
        {

            using (var db = new AppDbContext())
            {
                var locations = db.Locations.ToList();

                return locations;
            }
        }
        public Location GetLocationById(int id)
        {
            using (var db = new AppDbContext())
            {
                var location = db.Locations.FirstOrDefault(v => v.Id == id);
                return location;
            }
        }

        public void DeleteLocation(int id)
        {
            using (var db = new AppDbContext())
            {
                var location = db.Locations.FirstOrDefault(v => v.Id == id);
                if (location != null)
                {
                    db.Locations.Remove(location);
                    db.SaveChanges();
                }
            }
        }
    }
}
