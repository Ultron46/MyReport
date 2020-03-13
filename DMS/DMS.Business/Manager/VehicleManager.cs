using AutoMapper;
using DMS.Business.Interface;
using DMS.BusinessEntity.Models;
using DMS.Data.Database;
using DMS.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Business.Manager
{
    public class VehicleManager : IVehicleManager
    {
        private IVehicleRepository _vehicleDataRepository;

        public VehicleManager() { }

        public VehicleManager(IVehicleRepository vehicleRepository)
        {
            _vehicleDataRepository = vehicleRepository;
        }
        public List<VehicleViewModel> GetAllVehicles()
        {
            List<VehicleViewModel> vehicleViewModels = new List<VehicleViewModel>();
            var vehicles = _vehicleDataRepository.GetAllVehicles();
            foreach (var vehicle in vehicles)
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Vehicle, VehicleViewModel>();
                });

                IMapper mapper = config.CreateMapper();
                var source = new Vehicle();
                source = vehicle;
                var dest = mapper.Map<Vehicle, VehicleViewModel>(source);
                vehicleViewModels.Add(dest);
            }

            return vehicleViewModels;
        }

        public VehicleViewModel GetVehicle(int id)
        {
            Vehicle vehicle = _vehicleDataRepository.GetVehicle(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Vehicle, VehicleViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new Vehicle();
            source = vehicle;
            var dest = mapper.Map<Vehicle, VehicleViewModel>(source);

            return dest;
        }

        public bool InsertVehicle(VehicleViewModel vehicle)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<VehicleViewModel, Vehicle>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new VehicleViewModel();
            source = vehicle;
            var dest = mapper.Map<VehicleViewModel, Vehicle>(source);

            bool status = _vehicleDataRepository.InsertVehicle(dest);
            return status;
        }

        public bool UpdateVehicle(VehicleViewModel vehicle)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<VehicleViewModel, Vehicle>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new VehicleViewModel();
            source = vehicle;
            var dest = mapper.Map<VehicleViewModel, Vehicle>(source);

            bool status = _vehicleDataRepository.UpdateVehicle(dest);
            return status;
        }

        public bool DeleteVehicle(int id)
        {
            bool status = _vehicleDataRepository.DeleteVehicle(id);
            return status;
        }
    }
}
