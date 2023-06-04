using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Forms
{
    internal class TaskPlanRepository
    {
        public TaskPlan AddTaskPlan(TaskPlan TaskPlan)
        {
            using (var db = new AppDbContext())
            {
                var savedTaskPlan = db.TaskPlans.Add(TaskPlan);
                db.SaveChanges();
                return savedTaskPlan.Entity;
            }
        }

        public List<TaskPlan> GetAllTaskPlans()
        {

            using (var db = new AppDbContext())
            {
                var TaskPlans = db.TaskPlans.ToList();

                return TaskPlans;
            }
        }
        public TaskPlan GetTaskPlanById(int id)
        {
            using (var db = new AppDbContext())
            {
                var TaskPlan = db.TaskPlans.FirstOrDefault(v => v.Id == id);
                return TaskPlan;
            }
        }

        public void DeleteTaskPlan(int id)
        {
            using (var db = new AppDbContext())
            {
                var TaskPlan = db.TaskPlans.FirstOrDefault(v => v.Id == id);
                if (TaskPlan != null)
                {
                    db.TaskPlans.Remove(TaskPlan);
                    db.SaveChanges();
                }
            }
        }
    }
}