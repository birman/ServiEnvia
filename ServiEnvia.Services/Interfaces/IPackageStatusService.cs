using ServiEnvia.Data.EF.ConText;
using System.Collections.Generic;

namespace ServiEnvia.Services.Interfaces
{
    public interface IPackageStatusService
    {
        IEnumerable<PackageStatus> GetAllPackageStatus();

        PackageStatus GetPackageStatusById(int id);
    }
}