using ServiEnvia.Data.EF.ConText;
using ServiEnvia.Repositories.Base;
using ServiEnvia.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ServiEnvia.Repositories.Implementations
{
    public class PackageStatusRepository : EFBaseRepository, IPackageStatusRepository
    {
        public PackageStatusRepository(ServiEnviaDBEntities dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<PackageStatus> GetAllPackageStatus()
        {
            return _context.PackageStatus;
        }

        public PackageStatus GetPackageStatusById(int id)
        {
            return _context.PackageStatus.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}