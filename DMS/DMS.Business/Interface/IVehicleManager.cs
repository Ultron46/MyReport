using DMS.BusinessEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Business.Interface
{
    public interface IVehicleManager
    {
        List<VehicleViewModel> GetAllVehicles();
        VehicleViewModel GetVehicle(int id);
        bool InsertVehicle(VehicleViewModel vehicle);
        bool UpdateVehicle(VehicleViewModel vehicle);
        bool DeleteVehicle(int id);
    }
}
