using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class VehicleBrand
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }

        public string VehicleType { get; set; }
    }
}
