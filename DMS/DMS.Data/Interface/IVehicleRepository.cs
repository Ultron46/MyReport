using DMS.Data.Database;
using System.Collections.Generic;

namespace DMS.Data.Interface
{
    public interface IVehicleRepository
    {
        List<Vehicle> GetAllVehicles();
        Vehicle GetVehicle(int id);
        bool InsertVehicle(Vehicle vehicle);
        bool UpdateVehicle(Vehicle vehicle);
        bool DeleteVehicle(int id);
    }
}
