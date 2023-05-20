using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class VehicleModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public VehicleBrand VehicleBrand { get; set; }
        public int VehicleBrandId { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
