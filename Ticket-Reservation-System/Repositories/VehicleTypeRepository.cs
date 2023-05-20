using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Repositories
{
    public class VehicleTypeRepository
    {
        public void AddVehicleType(VehicleType newVehicleType)
        {
            using(var db = new AppDbContext())
            {
                db.VehicleTypes.Add(newVehicleType);
                db.SaveChanges();
            }
        }
        public List<VehicleType> GetAllVehicleTypes() 
        {
            using (var db = new AppDbContext())
            {
                var allVehicleTypes = db.VehicleTypes.ToList();
                return allVehicleTypes;
            }
        }
        public VehicleType GetVehicleTypeById(int id)
        {
            using (var db = new AppDbContext())
            {
                var vehicleType = db.VehicleTypes.FirstOrDefault(v => v.Id == id);
                return vehicleType;
            }
        }
        public void DeleteVehicleType(int id)
        {
            using (var db = new AppDbContext())
            {
                var vehicleType = db.VehicleTypes.FirstOrDefault(v => v.Id == id);
                if(vehicleType != null)
                {
                    db.VehicleTypes.Remove(vehicleType);
                    db.SaveChanges();
                }
            }
        }
        public void UpdateVehicleType(VehicleType vehicleTypeRequest)
        {
            using (var db = new AppDbContext()){
                var vehicleType = db.VehicleTypes.FirstOrDefault(v => v.Id == vehicleTypeRequest.Id);
                if(vehicleType != null)
                {
                    vehicleType.Name = vehicleTypeRequest.Name;

                    db.VehicleTypes.Update(vehicleType);
                    db.SaveChanges();
                }
            }
        }
    }
}
