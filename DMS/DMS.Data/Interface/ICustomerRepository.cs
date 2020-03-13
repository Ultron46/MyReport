using DMS.Data.Database;
using System.Collections.Generic;

namespace DMS.Data.Interface
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomer(int id);
        bool InsertCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(int id);
    }
}
