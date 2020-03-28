using ServiEnvia.Data.EF.ConText;
using ServiEnvia.Repositories.Base;
using ServiEnvia.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ServiEnvia.Repositories.Implementations
{
    public class PackageRepository : EFBaseRepository, IPackageRepository
    {
        public PackageRepository(ServiEnviaDBEntities dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Package> GetPackages()
        {
            return _context.Package;
        }

        public Package GetPackageByGuideId(long guideId)
        {
            return _context.Package.Where(p => p.GuideId == guideId).FirstOrDefault();
        }
    }
}