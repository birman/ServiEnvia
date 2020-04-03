using ServiEnvia.Data.EF.ConText;
using ServiEnvia.Repositories.Base;
using System.Collections.Generic;

namespace ServiEnvia.Repositories.Interfaces
{
    public interface IPackageStatusRepository : IEFBaseRepository
    {
        IEnumerable<PackageStatus> GetAllPackageStatus();

        PackageStatus GetPackageStatusById(int id);
    }
}