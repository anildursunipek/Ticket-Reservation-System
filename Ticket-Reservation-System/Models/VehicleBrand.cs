using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class VehicleBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }

        public List<VehicleModel> VehicleModels { get; set; }
    }
}
