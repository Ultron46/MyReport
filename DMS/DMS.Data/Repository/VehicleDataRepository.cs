using DMS.Data.Database;
using DMS.Data.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Data.Repository
{
    public class VehicleDataRepository : IVehicleRepository
    {
        private DMSEntities DMSEntities;
        public VehicleDataRepository()
        {
            DMSEntities = new DMSEntities();
        }

        public List<Vehicle> GetAllVehicles()
        {
            return DMSEntities.Vehicles.ToList();
        }

        public Vehicle GetVehicle(int id)
        {
            Vehicle vehicle = DMSEntities.Vehicles.Find(id);
            return vehicle;
        }

        public bool InsertVehicle(Vehicle vehicle)
        {
            bool status = false;

            Vehicle vehicleTemp = new Vehicle();
            vehicleTemp = vehicle;
            DMSEntities.Vehicles.Add(vehicleTemp);
            if (DMSEntities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }

        public bool UpdateVehicle(Vehicle vehicle)
        {
            bool status = false;
            Vehicle vehicleTemp = new Vehicle();
            vehicleTemp = vehicle;
            DMSEntities.Entry(vehicleTemp).State = EntityState.Modified;
            if(DMSEntities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }
        
        public bool DeleteVehicle(int id)
        {
            bool status = false;
            Vehicle vehicle = new Vehicle();
            vehicle = DMSEntities.Vehicles.Find(id);
            DMSEntities.Vehicles.Remove(vehicle);
            if(DMSEntities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
