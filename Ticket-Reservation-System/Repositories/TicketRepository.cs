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
        public void UpdateTicket(Ticket ticket)
        {
            using (var db = new AppDbContext())
            {
                var existingTicket = db.Tickets.Find(ticket.Id);
                if (existingTicket != null)
                {
                    existingTicket.UserId = ticket.UserId;
                    existingTicket.Price = ticket.Price;
                    existingTicket.PurchaseDate = ticket.PurchaseDate;
                    existingTicket.Status = ticket.Status;
                    existingTicket.TaskId = ticket.TaskId;
                    existingTicket.TicketPlanId = ticket.TicketPlanId;
                    db.SaveChanges();
                }
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
        public List<Ticket> getTicketsByTask(int id)
        {
            using (var db = new AppDbContext())
            {
                List<Ticket> tickets = db.Tickets.Where(v => v.TaskId == id).ToList();
                foreach (var ticket in tickets)
                {
                    ticket.Task = new TaskRepository().GetTaskById(ticket.TaskId);
                    ticket.TicketPlan = new TicketPlanRepository().GetTicketPlanById(ticket.TicketPlanId);
                }
                return tickets;
            }
        }
        public List<Ticket> getTicketsByTaskAndStatus(int id, string status)
        {
            using (var db = new AppDbContext())
            {
                List<Ticket> tickets = db.Tickets.Where(v => v.TaskId == id && v.Status == status).ToList();
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
                ticket.Task = new TaskRepository().GetTaskById(ticket.TaskId);
                ticket.TicketPlan = new TicketPlanRepository().GetTicketPlanById(ticket.TicketPlanId);
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
