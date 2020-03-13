using DMS.Business.Interface;
using DMS.Business.Manager;
using DMS.Business.UnityResolverHelper;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace DMS.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ICustomerManager, CustomerManager>();
            container.RegisterType<IDealerManager, DealerManager>();
            container.RegisterType<IVehicleManager, VehicleManager>();
            container.AddNewExtension<UnityRepositoryHelper>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}