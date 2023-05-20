﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Repositories
{
    public class VehicleBrandRepository
    {
        public void AddVehicleBrand(VehicleBrand vehicleBrand)
        {
            using(var db = new AppDbContext())
            {
                db.VehicleBrands.Add(vehicleBrand);
                db.SaveChanges();
            }
        }

        public List<VehicleBrand> GetAllVehicleBrands()
        {

            using (var db = new AppDbContext())
            {
                var vehicleBrands = db.VehicleBrands.ToList();
                foreach(var vehicleBrand in vehicleBrands)
                {
                    vehicleBrand.VehicleType = new VehicleTypeRepository().GetVehicleTypeById(vehicleBrand.VehicleTypeId);
                }

                return vehicleBrands;
            }
        }
        public VehicleBrand GetVehicleBrandById(int id)
        {
            using(var db= new AppDbContext())
            {
                var vehicleBrand = db.VehicleBrands.FirstOrDefault(v => v.Id == id);
                vehicleBrand.VehicleType = new VehicleTypeRepository().GetVehicleTypeById(vehicleBrand.VehicleTypeId);
                return vehicleBrand;
            }
        }

        public void DeleteVehicleBrand(int id) {
            using(var db= new AppDbContext())
            {
                var vehicleBrand = db.VehicleBrands.FirstOrDefault(v => v.Id == id);
                if(vehicleBrand != null)
                {
                    db.VehicleBrands.Remove(vehicleBrand);
                    db.SaveChanges();
                }
            }
        }
        public void UpdateVehicleBrand(VehicleBrand vehicleBrandRequest)
        {
            using (var db = new AppDbContext())
            {
                var vehicleBrand = db.VehicleBrands.FirstOrDefault(v => v.Id == vehicleBrandRequest.Id);
                if (vehicleBrand != null)
                {
                    vehicleBrand.Name = vehicleBrandRequest.Name;
                    vehicleBrand.VehicleTypeId = vehicleBrandRequest.VehicleTypeId;

                    db.VehicleBrands.Update(vehicleBrand);
                    db.SaveChanges();
                }
            }
        }

    }
}
