﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class Reservation
    {
        [Key]

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }
        public int UserId { get; set; }
        public Ticket Ticket { get; set; }
        public int TicketId { get; set; }
    }
}
