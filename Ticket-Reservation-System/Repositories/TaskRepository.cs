using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket_Reservation_System.Forms;

namespace Ticket_Reservation_System.Repositories
{
    internal class TaskRepository
    {
        public Models.Task AddTask(Models.Task task)
        {
            using (var db = new AppDbContext())
            {
                var savedTask = db.Tasks.Add(task);
                db.SaveChanges();
                return savedTask.Entity;
            }
        }

        public List<Models.Task> GetAllTasks()
        {

            using (var db = new AppDbContext())
            {
                var tasks = db.Tasks.ToList();

                foreach (var task in tasks)
                {
                    task.TaskPlan = new TaskPlanRepository().GetTaskPlanById(task.TaskPlanId);
                    task.Process = new ProcessRepository().GetProcessById(task.ProcessId);
                }
                return tasks;
            }
        }
        public Models.Task GetTaskById(int id)
        {
            using (var db = new AppDbContext())
            {
                var task = db.Tasks.FirstOrDefault(v => v.Id == id);
                task.TaskPlan = new TaskPlanRepository().GetTaskPlanById(task.TaskPlanId);
                task.Process = new ProcessRepository().GetProcessById(task.ProcessId);

                return task;
            }
        }

        public void DeleteTask(int id)
        {
            using (var db = new AppDbContext())
            {
                var task = db.Tasks.FirstOrDefault(v => v.Id == id);
                if (task != null)
                {
                    db.Tasks.Remove(task);
                    db.SaveChanges();
                }
            }
        }
    }
}
