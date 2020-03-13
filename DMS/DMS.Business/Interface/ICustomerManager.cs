using DMS.BusinessEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Business.Interface
{
    public interface ICustomerManager
    {
        List<CustomerViewModel> GetAllCustomers();
        CustomerViewModel GetCustomer(int id);
        bool InsertCustomer(CustomerViewModel customer);
        bool UpdateCustomer(CustomerViewModel customer);
        bool DeleteCustomer(int id);
    }
}
