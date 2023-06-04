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

        public void AddSeat(Seat seat)
        {
            using (var db = new AppDbContext())
            {
                db.Seats.Add(seat);
                db.SaveChanges();
            }
        }

        public List<Seat> GetAllSeats()
        {

            using (var db = new AppDbContext())
            {
                var seats = db.Seats.ToList();
                foreach (var seat in seats)
                {
                    seat.Vehicle = new VehicleRepository().GetVehicleById(seat.VehicleId);
                }

                return seats;
            }
        }
        public Seat GetSeatById(int id)
        {
            using (var db = new AppDbContext())
            {
                var seat = db.Seats.FirstOrDefault(v => v.Id == id);
                seat.Vehicle = new VehicleRepository().GetVehicleById(seat.VehicleId);

                return seat;
            }
        }
        public Seat getSeatByTypeAndVehicle(int vehicleId, string type)
        {
            using (var db = new AppDbContext())
            {
                var seat = db.Seats.FirstOrDefault(v => v.SeatType == type && v.VehicleId == vehicleId);
                return seat;
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
                var seat = db.Seats.FirstOrDefault(v => v.Id == id);
                if (seat != null)
                {
                    db.Seats.Remove(seat);
                    db.SaveChanges();
                }
            }
        }
    }
}
