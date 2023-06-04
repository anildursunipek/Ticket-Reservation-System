using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Reservation_System.Forms;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Repositories
{
    internal class ProcessRepository
    {

        public Process AddProcess(Process process)
        {
            using (var db = new AppDbContext())
            {
                var savedProcess = db.Processes.Add(process);
                db.SaveChanges();
                return savedProcess.Entity;
            }
        }

        public List<List<Models.Task>> searchByDateAndTrip(Location _startingPoint, Location _destinationPoint, string type, DateTime dateTime)
        {
            List<Models.Task> tasks;
            List<List<Models.Task>> savedTasks = new List<List<Models.Task>>();
            bool startFlag = false;
            bool destinationFlag = false;
            bool saveFlag = false;

            using (var db = new AppDbContext())
            {
                var processes = db.Processes.Where(process => process.Date.Date == dateTime.Date).ToList();
                foreach (var process in processes)
                {
                    tasks = new TaskRepository().GetTaskByProcess(process.Id);
                    List<Models.Task> addTasks = new List<Models.Task>();
                    startFlag = false;
                    destinationFlag = false;
                    saveFlag = false;

                    foreach (var task in tasks)
                    {
                        if (task.TaskPlan.StartingPoint.Id == _startingPoint.Id)
                        {
                            startFlag = true;
                        }
                        if (startFlag)
                        {
                            addTasks.Add(task);
                        }
                        if (task.TaskPlan.DestinationPoint.Id == _destinationPoint.Id)
                        {
                            destinationFlag = true;
                        }

                        if(startFlag == true && destinationFlag == true)
                        {
                            saveFlag = true;
                            break;
                        }
                    }
                    if(saveFlag == true)
                    {
                        savedTasks.Add(addTasks);
                    }
                }

            }
            return savedTasks;
        }
        public List<Process> GetAllProcesses()
        {
            using (var db = new AppDbContext())
            {
                var processes = db.Processes.ToList();

                foreach (var process in processes)
                {
                    process.Trip = new TripRepository().GetTripById(process.TripId);
                    process.Worker = new WorkerRepository().GetWorkerById(process.WorkerId);
                }
                return processes;
            }
        }
        public Process GetProcessById(int id)
        {
            using (var db = new AppDbContext())
            {
                var process = db.Processes.FirstOrDefault(v => v.Id == id);
                process.Trip = new TripRepository().GetTripById(process.TripId);
                process.Worker = new WorkerRepository().GetWorkerById(process.WorkerId);

                return process;
            }
        }

        public void DeleteProcess(int id)
        {
            using (var db = new AppDbContext())
            {
                var process = db.Processes.FirstOrDefault(v => v.Id == id);
                if (process != null)
                {
                    db.Processes.Remove(process);
                    db.SaveChanges();
                }
            }
        }
    }
}
