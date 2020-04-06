using ServiEnvia.Data.EF.ConText;
using ServiEnvia.Repositories.Interfaces;
using ServiEnvia.Services.Interfaces;
using System.Collections.Generic;

namespace ServiEnvia.Services.Implementations
{
    public class PackageService : IPackageService
    {
        public IPackageRepository _packageRepository;

        public IShippingPricesService _shippingPricesService;

        public PackageService(IPackageRepository packageRepository, IShippingPricesService shippingPricesService)
        {
            _packageRepository = packageRepository;
            _shippingPricesService = shippingPricesService;
        }

        public void SavePackage(Package package)
        {
            package.ShippingCost = _shippingPricesService.CalculateShippingPrice(package);
            package.PackageStatus = 1;
            _packageRepository.Add(package, true);
        }

        public void EditPackage(Package package)
        {
            _packageRepository.Detach(package);
            _packageRepository.Edit(package, true);
        }

        public void DetachPackage(Package package)
        {
            _packageRepository.Detach(package);
        }

        public void DeletePackage(Package package)
        {
            _packageRepository.Delete(package, true);
        }

        public Package GetPackageByGuideId(long id)
        {
            return _packageRepository.GetPackageByGuideId(id);
        }

        public IEnumerable<Package> GetPackages()
        {
            return _packageRepository.GetPackages();
        }
    }
}