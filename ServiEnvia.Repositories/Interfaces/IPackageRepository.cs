using ServiEnvia.Data.EF.ConText;
using System.Collections.Generic;

namespace ServiEnvia.Repositories.Interfaces
{
    public interface IPackageRepository
    {
        IEnumerable<Package> GetPackages();
        Package GetPackageByGuideId(long guideId);
    }
}