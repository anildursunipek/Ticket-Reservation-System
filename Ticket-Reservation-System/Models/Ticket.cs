using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Status { get; set; }
        public TicketPlan TicketPlan { get; set; }
        public int TicketPlanId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Reservation? Reservation { get; set; }
    }
}
