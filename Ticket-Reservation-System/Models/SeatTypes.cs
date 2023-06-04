using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class SeatTypes
    {
        public List<string> getSeatTypes()
        {
            List<string> seatTypes = new List<string>();
            seatTypes.Add("NORMAL");
            seatTypes.Add("PREMIUM");
            seatTypes.Add("BUSINESS");
            return seatTypes;
        }
    }
}
