using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class TaskPlan
    {
        [Key]
        public int Id { get; set; }
        public int Route { get; set; }
        public double Duration { get; set; }
        public int StartingPointId { get; set; }
        public Location StartingPoint { get; set; }
        public int DestinationPointId { get; set; }
        public Location DestinationPoint { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
