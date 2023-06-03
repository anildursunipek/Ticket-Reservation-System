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

        public void AddLocation(Location Location)
        {
            using (var db = new AppDbContext())
            {
                db.Locations.Add(Location);
                db.SaveChanges();
            }
        }

        public List<Location> GetAllLocations()
        {

            using (var db = new AppDbContext())
            {
                var Locations = db.Locations.ToList();

                return Locations;
            }
        }
        public Location GetLocationById(int id)
        {
            using (var db = new AppDbContext())
            {
                var Location = db.Locations.FirstOrDefault(v => v.Id == id);
                return Location;
            }
        }

        public void DeleteLocation(int id)
        {
            using (var db = new AppDbContext())
            {
                var Location = db.Locations.FirstOrDefault(v => v.Id == id);
                if (Location != null)
                {
                    db.Locations.Remove(Location);
                    db.SaveChanges();
                }
            }
        }
    }
}
