using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Repositories
{
    internal class FirmRepository
    {

        public void AddFirm(Firm firm)
        {
            using (var db = new AppDbContext())
            {
                db.Firms.Add(firm);
                db.SaveChanges();
            }
        }

        public List<Firm> GetAllFirms()
        {

            using (var db = new AppDbContext())
            {
                var firms = db.Firms.ToList();

                return firms;
            }
        }
        public Firm GetFirmById(int id)
        {
            using (var db = new AppDbContext())
            {
                var firm = db.Firms.FirstOrDefault(v => v.Id == id);
                return firm;
            }
        }

        public void DeleteFirm(int id)
        {
            using (var db = new AppDbContext())
            {
                var firm = db.Firms.FirstOrDefault(v => v.Id == id);
                if (firm != null)
                {
                    db.Firms.Remove(firm);
                    db.SaveChanges();
                }
            }
        }
    }
}
