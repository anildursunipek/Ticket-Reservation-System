using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Repositories
{
    internal class SeatRepository
    {

        public void AddSeat(Seat Seat)
        {
            using (var db = new AppDbContext())
            {
                db.Seats.Add(Seat);
                db.SaveChanges();
            }
        }

        public List<Seat> GetAllSeats()
        {

            using (var db = new AppDbContext())
            {
                var Seats = db.Seats.ToList();
                foreach (var seat in Seats)
                {
                    seat.Vehicle = new VehicleRepository().GetVehicleById(seat.VehicleId);
                }

                return Seats;
            }
        }
        public Seat GetSeatById(int id)
        {
            using (var db = new AppDbContext())
            {
                var Seat = db.Seats.FirstOrDefault(v => v.Id == id);
                return Seat;
            }
        }
        public List<Seat> GetSeatByVehichle(int id)
        {
            return GetAllSeats().FindAll(seat => seat.VehicleId == id);
        }

        public void DeleteSeat(int id)
        {
            using (var db = new AppDbContext())
            {
                var Seat = db.Seats.FirstOrDefault(v => v.Id == id);
                if (Seat != null)
                {
                    db.Seats.Remove(Seat);
                    db.SaveChanges();
                }
            }
        }
    }
}
