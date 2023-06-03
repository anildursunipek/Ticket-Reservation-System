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

        public void AddFirm(Firm Firm)
        {
            using (var db = new AppDbContext())
            {
                db.Firms.Add(Firm);
                db.SaveChanges();
            }
        }

        public List<Firm> GetAllFirms()
        {

            using (var db = new AppDbContext())
            {
                var Firms = db.Firms.ToList();

                return Firms;
            }
        }
        public Firm GetFirmById(int id)
        {
            using (var db = new AppDbContext())
            {
                var Firm = db.Firms.FirstOrDefault(v => v.Id == id);
                return Firm;
            }
        }

        public void DeleteFirm(int id)
        {
            using (var db = new AppDbContext())
            {
                var Firm = db.Firms.FirstOrDefault(v => v.Id == id);
                if (Firm != null)
                {
                    db.Firms.Remove(Firm);
                    db.SaveChanges();
                }
            }
        }
    }
}
