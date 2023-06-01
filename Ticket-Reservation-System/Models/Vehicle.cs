using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class Vehicle
    {
        [Key]

        public int Id { get; set; }
        public int TotalSeat { get; set; }
        public string Plate { get; set; }

        public VehicleModel VehicleModel { get; set; }
        public int VehicleModelId { get; set; }

        public Firm Firm { get; set; }
        public int FirmId { get; set;}
        public List<Seat> Seats { get; set; }
    }
}
