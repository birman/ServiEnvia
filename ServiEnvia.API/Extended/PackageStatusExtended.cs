using ServiEnvia.API.ViewModels;
using ServiEnvia.Data.EF.ConText;
using System.Collections.Generic;

namespace ServiEnvia.API.Extended
{
    public static class PackageStatusExtended
    {
        public static PackageStatusViewModel EntityToModel(this PackageStatus packageStatus)
        {
            return new PackageStatusViewModel
            {
                Id = packageStatus.Id,
                Description = packageStatus.Description
            };
        }

        public static IEnumerable<PackageStatusViewModel> EntityToModel(this IEnumerable<PackageStatus> listPackageStatus)
        {
            if (listPackageStatus == null) yield return null;
            else
                foreach (var item in listPackageStatus)
                {
                    yield return EntityToModel(item);
                }
        }

        public static PackageStatus ModelToEntity(this PackageStatusViewModel packageStatus)
        {
            return new PackageStatus
            {
                Id = packageStatus.Id,
                Description = packageStatus.Description

            };
        }

        public static IEnumerable<PackageStatus> ModelToEntity(this IEnumerable<PackageStatusViewModel> listPackageStatusViewModels)
        {
            if (listPackageStatusViewModels == null) yield return null;
            else
                foreach (var item in listPackageStatusViewModels)
                {
                    yield return ModelToEntity(item);
                }
        }
    }
}