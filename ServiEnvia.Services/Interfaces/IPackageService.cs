using ServiEnvia.Data.EF.ConText;
using System.Collections.Generic;

namespace ServiEnvia.Services.Interfaces
{
    public interface IPackageService
    {
        void SavePackage(Package package);

        void EditPackage(Package package);

        void DetachPackage(Package package);

        void DeletePackage(Package package);

        Package GetPackageByGuideId(long id);

        IEnumerable<Package> GetPackages();
    }
}