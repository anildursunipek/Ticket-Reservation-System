using System;
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
        public VehicleBrand AddVehicleBrand(VehicleBrand vehicleBrand)
        {
            using(var db = new AppDbContext())
            {
                var savedVehicleBrand = db.VehicleBrands.Add(vehicleBrand);
                db.SaveChanges();
                return savedVehicleBrand.Entity;
            }
        }

        public List<VehicleBrand> GetAllVehicleBrands()
        {

            using (var db = new AppDbContext())
            {
                var vehicleBrands = db.VehicleBrands.ToList();

                return vehicleBrands;
            }
        }
        public VehicleBrand GetVehicleBrandById(int id)
        {
            using(var db= new AppDbContext())
            {
                var vehicleBrand = db.VehicleBrands.FirstOrDefault(v => v.Id == id);
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

                    db.VehicleBrands.Update(vehicleBrand);
                    db.SaveChanges();
                }
            }
        }

    }
}
