using ServiEnvia.Data.EF.ConText;
using ServiEnvia.Repositories.Base;
using ServiEnvia.Repositories.Interfaces;
using System.Collections.Generic;

namespace ServiEnvia.Repositories.Implementations
{
    public class PackageStatusRepository : EFBaseRepository, IPackageStatusRepository
    {
        public PackageStatusRepository(ServiEnviaDBEntities dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<PackageStatus> GetPackageStatus()
        {
            return _context.PackageStatus;
        }
    }
}