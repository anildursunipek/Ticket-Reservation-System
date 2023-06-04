using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
