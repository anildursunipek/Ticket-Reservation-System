using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Reservation_System.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        [Required]
        public string Surname { get; set; }
        [MaxLength(100)]
        [Required]
        public string Email { get; set; }
        [MaxLength(40)]
        [Required]
        public int UserName { get; set; }
        [MaxLength(40)]
        [Required]
        public string Password { get; set; }
        [MaxLength(1)]
        [Required]
        public string Gender { get; set; }
        [MaxLength(40)]
        [Required]
        public string IdentityNumber { get; set; }
        [MaxLength(30)]
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public DateTime Birthday { get; set; }

        public List<Ticket> Tickets { get; set; }
        //public List<Reservation> Reservations { get; set; }


    }
}
