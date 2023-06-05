using Ticket_Reservation_System.Models;
using Ticket_Reservation_System.Repositories;

namespace Ticket_Reservation_System.Forms
{
    public class TaskPlanRepository
    {
        public TaskPlan AddTaskPlan(TaskPlan taskPlan)
        {
            using (var db = new AppDbContext())
            {
                var savedTaskPlan = db.TaskPlans.Add(taskPlan);
                db.SaveChanges();
                return savedTaskPlan.Entity;
            }
        }

        public List<TaskPlan> GetAllTaskPlans()
        {

            using (var db = new AppDbContext())
            {
                var taskPlans = db.TaskPlans.ToList();
                foreach (var taskPlan in taskPlans)
                {
                    taskPlan.StartingPoint = new LocationRepository().GetLocationById(taskPlan.StartingPointId);
                    taskPlan.DestinationPoint = new LocationRepository().GetLocationById(taskPlan.DestinationPointId);
                    taskPlan.Trip = new TripRepository().GetTripById(taskPlan.TripId);
                }
                return taskPlans;
            }
        }

        public List<TaskPlan> getTaskPlanByTrip(int id)
        {
            return GetAllTaskPlans().FindAll(taskPlan => taskPlan.TripId == id);
        }
        public TaskPlan GetTaskPlanById(int id)
        {
            using (var db = new AppDbContext())
            {
                var taskPlan = db.TaskPlans.FirstOrDefault(v => v.Id == id);
                taskPlan.StartingPoint = new LocationRepository().GetLocationById(taskPlan.StartingPointId);
                taskPlan.DestinationPoint = new LocationRepository().GetLocationById(taskPlan.DestinationPointId);
                taskPlan.Trip = new TripRepository().GetTripById(taskPlan.TripId);
                return taskPlan;
            }
        }

        public void DeleteTaskPlan(int id)
        {
            using (var db = new AppDbContext())
            {
                var taskPlan = db.TaskPlans.FirstOrDefault(v => v.Id == id);
                if (taskPlan != null)
                {
                    db.TaskPlans.Remove(taskPlan);
                    db.SaveChanges();
                }
            }
        }
    }
}