using AutoMapper;
using DMS.Business.Interface;
using DMS.BusinessEntity.Models;
using DMS.Data.Database;
using DMS.Data.Interface;
using System.Collections.Generic;

namespace DMS.Business.Manager
{
    public class CustomerManager : ICustomerManager
    {
        private ICustomerRepository _customerDataRepository;

        public CustomerManager() { }

        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerDataRepository = customerRepository;
        }
        public List<CustomerViewModel> GetAllCustomers()
        {
            List<CustomerViewModel> customerViewModel = new List<CustomerViewModel>();
            var customers = _customerDataRepository.GetAllCustomers();
            foreach(var customer in customers)
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Customer, CustomerViewModel>();
                });

                IMapper mapper = config.CreateMapper();
                var source = new Customer();
                source = customer;
                var dest = mapper.Map<Customer, CustomerViewModel>(source);
                customerViewModel.Add(dest);
            }
            
            return customerViewModel;
        }

        public CustomerViewModel GetCustomer(int id)
        {
            Customer customer = _customerDataRepository.GetCustomer(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Customer, CustomerViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = customer;
            var dest = mapper.Map<Customer, CustomerViewModel>(source);

            return dest;
        }

        public bool InsertCustomer(CustomerViewModel customer)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CustomerViewModel, Customer>();
            });

            IMapper mapper = config.CreateMapper();
            var source = customer;
            var dest = mapper.Map<CustomerViewModel, Customer>(source);

            bool status = _customerDataRepository.InsertCustomer(dest);
            return status;
        }

        public bool UpdateCustomer(CustomerViewModel customer)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CustomerViewModel, Customer>();
            });

            IMapper mapper = config.CreateMapper();
            var source = customer;
            var dest = mapper.Map<CustomerViewModel, Customer>(source);

            bool status = _customerDataRepository.UpdateCustomer(dest);
            return status;
        }

        public bool DeleteCustomer(int id)
        {
            bool status = _customerDataRepository.DeleteCustomer(id);
            return status;
        }
    }
}
