﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Repositories
{
    internal class VehicleRepository
    {
        public Vehicle AddVehicle(Vehicle vehicle)
        {
            using (var db = new AppDbContext())
            {
                var _savedVehicle = db.Vehicles.Add(vehicle);
                db.SaveChanges();
                return _savedVehicle.Entity;
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
        public List<Vehicle> GetVehiclesByFirmId(int id)
        {
            using (var db = new AppDbContext())
            {
                return GetAllVehicles().FindAll(vehicle => vehicle.FirmId == id);
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
    }
}
