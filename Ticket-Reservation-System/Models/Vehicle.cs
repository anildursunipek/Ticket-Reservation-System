using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int TotalSeat { get; set; }
        public string Plate { get; set; }

        public VehicleModel VehicleModel { get; set; }
        public int VehicleModelId { get; set; }
    }
}
