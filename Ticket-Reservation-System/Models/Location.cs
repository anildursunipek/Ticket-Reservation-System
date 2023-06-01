using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class Location
    {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public double lat { get; set; }
            public double lng { get; set; }

        }
}
