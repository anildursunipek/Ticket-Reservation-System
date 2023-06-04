using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Reservation_System.Forms;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Repositories
{
    public class TicketPlanRepository
    {

        public TicketPlan AddTicketPlan(TicketPlan ticketPlan)
        {
            using (var db = new AppDbContext())
            {
                var savedTicketPlan = db.TicketPlans.Add(ticketPlan);
                db.SaveChanges();
                return savedTicketPlan.Entity;
            }
        }

        public List<TicketPlan> GetAllTicketPlans()
        {

            using (var db = new AppDbContext())
            {
                var ticketPlans = db.TicketPlans.ToList();
                foreach (var ticketPlan in ticketPlans)
                {
                    ticketPlan.Seat = new SeatRepository().GetSeatById(ticketPlan.SeatId);
                    ticketPlan.TaskPlan = new TaskPlanRepository().GetTaskPlanById(ticketPlan.TaskPlanId);
                }
                return ticketPlans;
            }
        }

        public TicketPlan GetTicketPlanById(int id)
        {
            using (var db = new AppDbContext())
            {
                var ticketPlan = db.TicketPlans.FirstOrDefault(v => v.Id == id);
                ticketPlan.Seat = new SeatRepository().GetSeatById(ticketPlan.SeatId);
                ticketPlan.TaskPlan = new TaskPlanRepository().GetTaskPlanById(ticketPlan.TaskPlanId);
                return ticketPlan;
            }
        }

        public List<TicketPlan> GetTicketPlanByTaskPlan(int id)
        {
            using (var db = new AppDbContext())
            {
                var ticketPlans = db.TicketPlans.Where(ticketPlan => ticketPlan.TaskPlanId == id).ToList();
                
                foreach(var ticketPlan in ticketPlans)
                {
                    ticketPlan.Seat = new SeatRepository().GetSeatById(ticketPlan.SeatId);
                    ticketPlan.TaskPlan = new TaskPlanRepository().GetTaskPlanById(ticketPlan.TaskPlanId);
                }
                return ticketPlans;
            }
        }

        public List<ExpandoObject> getSeatTypePrices(int taskPlanId, int vehicleId)
        {
            using (var db = new AppDbContext())
            {
                List<string> types = new SeatTypes().getSeatTypes();
                List<ExpandoObject> _dynamicTypes = new List<ExpandoObject>();
                foreach (var type in types)
                {
                    var seat = new SeatRepository().getSeatByTypeAndVehicle(vehicleId, type);

                    dynamic _dynamic = new ExpandoObject();
                    _dynamic.Type = type;

                    if (seat == null)
                    {
                        _dynamic.Price = null;
                    }
                    else
                    {
                        TicketPlan ticketPlan = db.TicketPlans.FirstOrDefault(v => v.TaskPlanId == taskPlanId && v.SeatId == seat.Id);
                        if (ticketPlan != null)
                        {
                            _dynamic.Price = ticketPlan.Price;
                        }
                        else
                        {
                            _dynamic.Price = null;
                        }
                    }
                    _dynamicTypes.Add(_dynamic);
                }
                return _dynamicTypes;
            }

        }

        public void DeleteTicketPlan(int id)
        {
            using (var db = new AppDbContext())
            {
                var ticketPlan = db.TicketPlans.FirstOrDefault(v => v.Id == id);
                if (ticketPlan != null)
                {
                    db.TicketPlans.Remove(ticketPlan);
                    db.SaveChanges();
                }
            }
        }
    }
}
