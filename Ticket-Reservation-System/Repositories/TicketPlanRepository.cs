using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Repositories
{
    internal class TicketPlanRepository
    {

        public TicketPlan AddTicketPlan(TicketPlan TicketPlan)
        {
            using (var db = new AppDbContext())
            {
                var savedTicketPlan = db.TicketPlans.Add(TicketPlan);
                db.SaveChanges();
                return savedTicketPlan.Entity;
            }
        }

        public List<TicketPlan> GetAllTicketPlans()
        {

            using (var db = new AppDbContext())
            {
                var TicketPlans = db.TicketPlans.ToList();

                return TicketPlans;
            }
        }
        public TicketPlan GetTicketPlanById(int id)
        {
            using (var db = new AppDbContext())
            {
                var TicketPlan = db.TicketPlans.FirstOrDefault(v => v.Id == id);
                return TicketPlan;
            }
        }

        public void DeleteTicketPlan(int id)
        {
            using (var db = new AppDbContext())
            {
                var TicketPlan = db.TicketPlans.FirstOrDefault(v => v.Id == id);
                if (TicketPlan != null)
                {
                    db.TicketPlans.Remove(TicketPlan);
                    db.SaveChanges();
                }
            }
        }
    }
}
