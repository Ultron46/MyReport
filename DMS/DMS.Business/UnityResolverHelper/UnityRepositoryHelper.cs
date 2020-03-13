using DMS.Data.Interface;
using DMS.Data.Repository;
using Unity.Extension;
using Unity;

namespace DMS.Business.UnityResolverHelper
{
    public class UnityRepositoryHelper : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<ICustomerRepository, CustomerDataRepository>();
            Container.RegisterType<IDealerRepository, DealerDataRepository>();
            Container.RegisterType<IVehicleRepository, VehicleDataRepository>();
        }
    }
}
