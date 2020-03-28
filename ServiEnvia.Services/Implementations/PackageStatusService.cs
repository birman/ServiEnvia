using ServiEnvia.Data.EF.ConText;
using ServiEnvia.Repositories.Interfaces;
using ServiEnvia.Services.Interfaces;
using System.Collections.Generic;

namespace ServiEnvia.Services.Implementations
{
    public class PackageStatusService : IPackageStatusService
    {
        private IPackageStatusRepository _packageStatusRepository;

        public PackageStatusService(IPackageStatusRepository packageStatusRepository)
        {
            _packageStatusRepository = packageStatusRepository;
        }

        public IEnumerable<PackageStatus> GetPackageStatus()
        {
            return _packageStatusRepository.GetPackageStatus();
        }
    }
}