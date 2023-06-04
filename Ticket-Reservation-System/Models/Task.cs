using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public int TaskPlanId { get; set; }
        public TaskPlan TaskPlan { get; set; }
        public int ProcessId { get; set; }
        public Process Process { get; set; }
    }
}
