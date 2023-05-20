using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Repositories
{
    public class VehicleModelRepository
    {
        public void AddVehicleModel(VehicleModel vehicleModel)
        {
            using(var db= new AppDbContext())
            {
                db.VehicleModels.Add(vehicleModel);
                db.SaveChanges();
            }
        }
        public List<VehicleModel> GetAllVehicleModels() {
            using (var db = new AppDbContext())
            {
                var vehicleModels = db.VehicleModels.ToList();
                foreach (var vehicleModel in vehicleModels)
                {
                    vehicleModel.VehicleBrand = new VehicleBrandRepository().GetVehicleBrandById(vehicleModel.VehicleBrandId);
                }
                return vehicleModels;
            }
        }
        public VehicleModel GetVehicleModelById(int id)
        {
            using (var db = new AppDbContext())
            {
                var vehicleModel = db.VehicleModels.FirstOrDefault(v => v.Id == id);
                vehicleModel.VehicleBrand= new VehicleBrandRepository().GetVehicleBrandById(vehicleModel.VehicleBrandId);
                return vehicleModel;
            }
        }
        public void UpdateVehicleModel(VehicleModel vehicleModelRequest)
        {
            using(var db = new AppDbContext())
            {
                var vehicleModel = db.VehicleModels.FirstOrDefault(v => v.Id == vehicleModelRequest.Id);
                if(vehicleModel != null)
                {
                    vehicleModel.Name = vehicleModelRequest.Name;
                    vehicleModel.VehicleBrandId = vehicleModelRequest.VehicleBrandId;
                    db.VehicleModels.Update(vehicleModel);
                    db.SaveChanges();
                }
            }
        }
        public void DeleteVehicleModel(int id)
        {
            using (var db = new AppDbContext())
            {
                var vehicleModel = db.VehicleModels.FirstOrDefault(v => v.Id == id);
                if(vehicleModel != null)
                {
                    db.VehicleModels.Remove(vehicleModel); 
                    db.SaveChanges();
                }
            }
        }
    }
}
