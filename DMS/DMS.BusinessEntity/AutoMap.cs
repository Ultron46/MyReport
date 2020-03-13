using AutoMapper;
using DMS.BusinessEntity.Models;
using DMS.Data.Database;
using System.Collections.Generic;

namespace DMS.BusinessEntity
{
    public class AutoMap
    {
        public KeyValuePair<Vehicle,VehicleViewModel> MapVehicleViewModel()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Vehicle, VehicleViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new Vehicle();
            var dest = mapper.Map<Vehicle, VehicleViewModel>(source);
            return new KeyValuePair<Vehicle, VehicleViewModel>(source, dest);
        }

        public KeyValuePair<Customer, CustomerViewModel> MapCustomerViewModel()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Vehicle, VehicleViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new Customer();
            var dest = mapper.Map<Customer, CustomerViewModel>(source);
            return new KeyValuePair<Customer, CustomerViewModel>(source, dest);
        }
    }
}
