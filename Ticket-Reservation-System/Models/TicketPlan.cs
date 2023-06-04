﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class TicketPlan
    {
        [Key]

        public int Id { get; set; }
        public double Price { get; set; }
        public Seat Seat { get; set; }
        public int SeatId { get; set; }
        public TaskPlan TaskPlan { get; set; }
        public int TaskPlanId { get; set; }
    }
}
