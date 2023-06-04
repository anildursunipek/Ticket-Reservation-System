using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class Ticket
    {
        [Key]

        public int Id { get; set; }
        public User User { get; set; }
        public int? UserId { get; set; }
        public double Price { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string Status { get; set; }
        public Task Task { get; set; }
        public int TaskId { get; set; }
        public TicketPlan TicketPlan { get; set; }
        public int TicketPlanId { get; set; }
    }
}
