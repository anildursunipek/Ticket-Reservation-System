using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }
        public DateTime Duration { get; set; }
        public string Description { get; set; }
        public int StartingPointId { get; set; }
        public Location StartingPoint { get; set; }
        public int DestinationPointId { get; set; }
        public Location DestinationPoint { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
