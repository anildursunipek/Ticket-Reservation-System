using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class Seat
    {
        [Key]

        public int Id { get; set; }
        public string Department { get; set; }
        public int SeatNumber { get; set; }

        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }
        public string SeatType { get; set; }
        public List<TicketPlan> TicketPlans { get; set; }
    }
}
