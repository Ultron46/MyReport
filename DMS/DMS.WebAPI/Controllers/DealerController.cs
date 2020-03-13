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
    public class DealerController : ApiController
    {
        private IDealerManager _dealerManager;

        public DealerController() { }

        public DealerController(IDealerManager dealerManager)
        {
            _dealerManager = dealerManager;
        }

        public IHttpActionResult GetAllDealers()
        {
            var dealers = _dealerManager.GetAllDealers();
            if (dealers == null)
            {
                return NotFound();
            }
            return Ok(dealers);
        }

        public IHttpActionResult GetDealer(int id)
        {
            var dealer = _dealerManager.GetDealer(id);
            if (dealer == null)
            {
                return NotFound();
            }
            return Ok(dealer);
        }

        public bool InsertCustomer(DealerViewModel dealerView)
        {
            return _dealerManager.InsertDealer(dealerView);
        }

        public bool Updatecustomer(DealerViewModel dealerView)
        {
            return _dealerManager.UpdateDealer(dealerView);
        }

        public bool DeleteCustomer(int id)
        {
            return _dealerManager.DeleteDealer(id);
        }
    }
}
