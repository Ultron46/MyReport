using DMS.Data.Database;
using System.Collections.Generic;

namespace DMS.Data.Interface
{
    public interface IDealerRepository
    {
        List<Dealer> GetAllDealers();
        Dealer GetDealer(int id);
        bool InsertDealer(Dealer dealer);
        bool UpdateDealer(Dealer dealer);
        bool DeleteDealer(int id);
    }
}
