using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Repositories
{
    internal class VehicleRepository
    {
        public void AddVehicle(Vehicle vehicle)
        {
            using (var db = new AppDbContext())
            {
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
            }
        }

        public List<Vehicle> GetAllVehicles()
        {

            using (var db = new AppDbContext())
            {
                var vehicles = db.Vehicles.ToList();
                foreach (var vehicle in vehicles)
                {
                    vehicle.VehicleModel = new VehicleModelRepository().GetVehicleModelById(vehicle.VehicleModelId);
                    vehicle.Firm = new FirmRepository().GetFirmById(vehicle.FirmId);
                }

                return vehicles;
            }
        }
        public Vehicle GetVehicleById(int id)
        {
            using (var db = new AppDbContext())
            {
                var vehicle = db.Vehicles.FirstOrDefault(v => v.Id == id);
                vehicle.VehicleModel = new VehicleModelRepository().GetVehicleModelById(vehicle.VehicleModelId);
                vehicle.Firm = new FirmRepository().GetFirmById(vehicle.FirmId);
                return vehicle;
            }
        }

        public void DeleteVehicle(int id)
        {
            using (var db = new AppDbContext())
            {
                var vehicle = db.Vehicles.FirstOrDefault(v => v.Id == id);
                if (vehicle != null)
                {
                    db.Vehicles.Remove(vehicle);
                    db.SaveChanges();
                }
            }
        }
        //public void UpdateVehicle(Vehicle vehicleRequest)
        //{
        //    using (var db = new AppDbContext())
        //    {
        //        var vehicle = db.VehicleBrands.FirstOrDefault(v => v.Id == vehicleRequest.Id);
        //        if (vehicle != null)
        //        {
        //            vehicle.Name = vehicleRequest.Name;

        //            db.Vehicles.Update(vehicle);
        //            db.SaveChanges();
        //        }
        //    }
        //}
    }
}
