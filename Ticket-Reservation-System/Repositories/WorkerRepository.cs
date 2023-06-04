using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Repositories
{
    internal class WorkerRepository
    {
        public void AddWorker(Worker worker)
        {
            using (var db = new AppDbContext())
            {
                db.Workers.Add(worker);
                db.SaveChanges();
            }
        }

        public List<Worker> GetAllWorkers()
        {

            using (var db = new AppDbContext())
            {
                var workers = db.Workers.ToList();
                foreach (var Worker in workers)
                {
                    Worker.Firm = new FirmRepository().GetFirmById(Worker.FirmId);
                }

                return workers;
            }
        }
        public Worker GetWorkerById(int id)
        {
            using (var db = new AppDbContext())
            {
                var worker = db.Workers.FirstOrDefault(v => v.Id == id);
                worker.Firm = new FirmRepository().GetFirmById(worker.FirmId);

                return worker;
            }
        }
        public List<Worker> GetWorkerByFirm(int id)
        {
            return GetAllWorkers().FindAll(worker => worker.FirmId == id);
        }

        public void DeleteWorker(int id)
        {
            using (var db = new AppDbContext())
            {
                var worker = db.Workers.FirstOrDefault(v => v.Id == id);
                if (worker != null)
                {
                    db.Workers.Remove(worker);
                    db.SaveChanges();
                }
            }
        }
    }
}
