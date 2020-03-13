using DMS.Business.Interface;
using DMS.BusinessEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DMS.WebAPI.Controllers
{
    public class VehicleController : ApiController
    {
        private IVehicleManager _vehicleManager;

        public VehicleController() { }

        public VehicleController(IVehicleManager vehicleManager)
        {
            _vehicleManager = vehicleManager;
        }

        public IHttpActionResult GetAllDealers()
        {
            var vehicles = _vehicleManager.GetAllVehicles();
            if (vehicles == null)
            {
                return NotFound();
            }
            return Ok(vehicles);
        }

        public IHttpActionResult GetVehicle(int id)
        {
            var vehicle = _vehicleManager.GetVehicle(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return Ok(vehicle);
        }

        public bool InsertCustomer(VehicleViewModel vehicleView)
        {
            return _vehicleManager.InsertVehicle(vehicleView);
        }

        public bool Updatecustomer(VehicleViewModel vehicleView)
        {
            return _vehicleManager.UpdateVehicle(vehicleView);
        }

        public bool DeleteCustomer(int id)
        {
            return _vehicleManager.DeleteVehicle(id);
        }
    }
}
