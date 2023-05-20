﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class TicketPlan
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public Seat Seat { get; set; }
        public int SeatId { get; set; }
    }
}