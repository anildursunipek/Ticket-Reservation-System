using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Repositories
{
    internal class TicketRepository
    {
        public void AddTicket(Ticket ticket)
        {
            using (var db = new AppDbContext())
            {
                db.Tickets.Add(ticket);
                db.SaveChanges();
            }
        }

        public List<Ticket> GetAllTickets()
        {

            using (var db = new AppDbContext())
            {
                var tickets = db.Tickets.ToList();

                foreach (var ticket in tickets)
                {
                    ticket.Task = new TaskRepository().GetTaskById(ticket.TaskId);
                    ticket.TicketPlan = new TicketPlanRepository().GetTicketPlanById(ticket.TicketPlanId);
                }

                return tickets;
            }
        }
        public Ticket GetTicketById(int id)
        {
            using (var db = new AppDbContext())
            {
                var ticket = db.Tickets.FirstOrDefault(v => v.Id == id);
                return ticket;
            }
        }

        public void DeleteTicket(int id)
        {
            using (var db = new AppDbContext())
            {
                var ticket = db.Tickets.FirstOrDefault(v => v.Id == id);
                if (ticket != null)
                {
                    db.Tickets.Remove(ticket);
                    db.SaveChanges();
                }
            }
        }
    }
}
