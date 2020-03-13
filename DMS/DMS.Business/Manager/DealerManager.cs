using AutoMapper;
using DMS.Business.Interface;
using DMS.BusinessEntity.Models;
using DMS.Data.Database;
using DMS.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Business.Manager
{
    public class DealerManager : IDealerManager
    {
        private IDealerRepository _dealerDataRepository;

        public DealerManager() { }

        public DealerManager(IDealerRepository dealerRepository)
        {
            _dealerDataRepository = dealerRepository;
        }
        public List<DealerViewModel> GetAllDealers()
        {
            List<DealerViewModel> dealerViewModels = new List<DealerViewModel>();
            var dealers = _dealerDataRepository.GetAllDealers();
            foreach (var dealer in dealers)
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Dealer, DealerViewModel>();
                });

                IMapper mapper = config.CreateMapper();
                var source = new Dealer();
                source = dealer;
                var dest = mapper.Map<Dealer, DealerViewModel>(source);
                dealerViewModels.Add(dest);
            }

            return dealerViewModels;
        }

        public DealerViewModel GetDealer(int id)
        {
            Dealer dealer = _dealerDataRepository.GetDealer(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Dealer, DealerViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new Dealer();
            source = dealer;
            var dest = mapper.Map<Dealer, DealerViewModel>(source);

            return dest;
        }

        public bool InsertDealer(DealerViewModel dealer)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<DealerViewModel, Dealer>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new DealerViewModel();
            source = dealer;
            var dest = mapper.Map<DealerViewModel, Dealer>(source);

            bool status = _dealerDataRepository.InsertDealer(dest);
            return status;
        }

        public bool UpdateDealer(DealerViewModel dealer)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<DealerViewModel, Dealer>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new DealerViewModel();
            source = dealer;
            var dest = mapper.Map<DealerViewModel, Dealer>(source);

            bool status = _dealerDataRepository.UpdateDealer(dest);
            return status;
        }

        public bool DeleteDealer(int id)
        {
            bool status = _dealerDataRepository.DeleteDealer(id);
            return status;
        }
    }
}
