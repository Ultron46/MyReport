using DMS.Data.Database;
using DMS.Data.Interface;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DMS.Data.Repository
{
    public class CustomerDataRepository : ICustomerRepository
    {
        private DMSEntities DMSEntities;
        public CustomerDataRepository()
        {
            DMSEntities = new DMSEntities();
        }

        public List<Customer> GetAllCustomers()
        {
            return DMSEntities.Customers.ToList();
        }

        public Customer GetCustomer(int id)
        {
            Customer customer = DMSEntities.Customers.Find(id);
            return customer;
        }

        public bool InsertCustomer(Customer customer)
        {
            bool status = false;

            Customer customerTemp = new Customer();
            customerTemp = customer;
            DMSEntities.Customers.Add(customerTemp);
            if (DMSEntities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }

        public bool UpdateCustomer(Customer customer)
        {
            bool status = false;
            Customer customerTemp = new Customer();
            customerTemp = customer;
            DMSEntities.Entry(customer).State = EntityState.Modified;
            if (DMSEntities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }

        public bool DeleteCustomer(int id)
        {
            bool status = false;
            Customer customer = new Customer();
            customer = DMSEntities.Customers.Find(id);
            DMSEntities.Customers.Remove(customer);
            if (DMSEntities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
