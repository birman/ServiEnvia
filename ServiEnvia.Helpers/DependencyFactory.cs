using ServiEnvia.Data.EF.ConText;
using ServiEnvia.Repositories.Implementations;
using ServiEnvia.Repositories.Interfaces;
using ServiEnvia.Services.Implementations;
using ServiEnvia.Services.Interfaces;
using Unity;
using Unity.Injection;

namespace ServiEnvia.Helpers
{
    public static class DependencyFactory
    {
        public static IUnityContainer Container { get; private set; }

        static DependencyFactory()
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            Container = container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            // Register application database context
            container.RegisterType<ServiEnviaDBEntities>(new InjectionFactory(x => new ServiEnviaDBEntities()));

            // Register services
            container.RegisterType<ICustomerService, CustomerService>();
            container.RegisterType<IPackageService, PackageService>();
            container.RegisterType<IPackageStatusService, PackageStatusService>();
            container.RegisterType<IShippingPricesService, ShippingPricesService>();

            // Register repositories
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<IPackageRepository, PackageRepository>();
            container.RegisterType<IPackageStatusRepository, PackageStatusRepository>();
            container.RegisterType<IShippingPricesRepository, ShippingPricesRepository>();
        }

        public static T Resolve<T>()
        {
            T ret = default(T);

            if (Container.IsRegistered(typeof(T)))
            {
                ret = Container.Resolve<T>();
            }

            return ret;
        }

    }
}