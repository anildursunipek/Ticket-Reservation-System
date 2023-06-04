using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class Process
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Time { get; set; }
        public DateTime Date { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}
