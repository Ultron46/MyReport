using DMS.Business.Interface;
using DMS.BusinessEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DMS.WebAPI.Controllers
{
    [EnableCorsAttribute("*", "*", "*")]
    public class CustomerController : ApiController
    {
        private ICustomerManager _customerManager;

        public CustomerController() { }

        public CustomerController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }
        [Authorization]
        public IHttpActionResult GetAllCustomers()
        {
            var customers = _customerManager.GetAllCustomers();
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(customers);
        }

        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _customerManager.GetCustomer(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        public bool InsertCustomer(CustomerViewModel customerView)
        {
            return _customerManager.InsertCustomer(customerView);
        }

        public bool Updatecustomer(CustomerViewModel customerView)
        {
            return _customerManager.UpdateCustomer(customerView);
        }

        public bool DeleteCustomer(int id)
        {
            return _customerManager.DeleteCustomer(id);
        }
    }
}
