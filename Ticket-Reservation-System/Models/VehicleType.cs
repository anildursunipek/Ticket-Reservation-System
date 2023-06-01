using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class VehicleType
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public List<VehicleBrand> VehicleBrands { get; set; }

    }
}
