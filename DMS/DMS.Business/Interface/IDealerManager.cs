using DMS.BusinessEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Business.Interface
{
    public interface IDealerManager
    {
        List<DealerViewModel> GetAllDealers();
        DealerViewModel GetDealer(int id);
        bool InsertDealer(DealerViewModel dealer);
        bool UpdateDealer(DealerViewModel dealer);
        bool DeleteDealer(int id);
    }
}
