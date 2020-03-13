using DMS.Data.Database;
using DMS.Data.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Data.Repository
{
    public class DealerDataRepository : IDealerRepository
    {
        private DMSEntities DMSEntities;
        public DealerDataRepository()
        {
            DMSEntities = new DMSEntities();
        }

        public List<Dealer> GetAllDealers()
        {
            return DMSEntities.Dealers.ToList();
        }

        public Dealer GetDealer(int id)
        {
            Dealer dealer = DMSEntities.Dealers.Find(id);
            return dealer;
        }

        public bool InsertDealer(Dealer dealer)
        {
            bool status = false;

            Dealer dealerTemp = new Dealer();
            dealerTemp = dealer;
            DMSEntities.Dealers.Add(dealerTemp);
            if (DMSEntities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }

        public bool UpdateDealer(Dealer dealer)
        {
            bool status = false;
            Dealer dealerTemp = new Dealer();
            dealerTemp = dealer;
            DMSEntities.Entry(dealerTemp).State = EntityState.Modified;
            if (DMSEntities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }

        public bool DeleteDealer(int id)
        {
            bool status = false;
            Dealer dealer = new Dealer();
            dealer = DMSEntities.Dealers.Find(id);
            DMSEntities.Dealers.Remove(dealer);
            if (DMSEntities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
