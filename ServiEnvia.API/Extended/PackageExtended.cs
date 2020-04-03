using ServiEnvia.API.ViewModels;
using ServiEnvia.Data.EF.ConText;
using System.Collections.Generic;

namespace ServiEnvia.API.Extended
{
    public static class PackageExtended
    {
        public static PackageViewModel EntityToModel(this Package package)
        {
            return new PackageViewModel
            {
                GuideId = package.GuideId,
                CustomerId = package.CustomerId,
                PackageStatus = package.PackageStatus,
                RecipientId = package.RecipientId,
                RecipientName = package.RecipientName,
                RecipientLastName = package.RecipientLastName,
                OriginCity = package.OriginCity,
                DestinationCity = package.DestinationCity,
                Weight = package.Weight,
                InsuranceCost = package.InsuranceCost,
                ShippingCost = package.ShippingCost,
                InsuredCost = package.InsuredCost
            };
        }

        public static IEnumerable<PackageViewModel> EntityToModel(this IEnumerable<Package> listPackage)
        {
            if (listPackage == null) yield return null;
            else
                foreach (var item in listPackage)
                {
                    yield return EntityToModel(item);
                }
        }

        public static Package ModelToEntity(this PackageViewModel package)
        {
            return new Package
            {
                GuideId = package.GuideId,
                CustomerId = package.CustomerId,
                PackageStatus = package.PackageStatus,
                RecipientId = package.RecipientId,
                RecipientName = package.RecipientName,
                RecipientLastName = package.RecipientLastName,
                OriginCity = package.OriginCity,
                DestinationCity = package.DestinationCity,
                Weight = package.Weight,
                InsuranceCost = package.InsuranceCost,
                ShippingCost = package.ShippingCost,
                InsuredCost = package.InsuredCost
            };
        }

        public static IEnumerable<Package> ModelToEntity(this IEnumerable<PackageViewModel> listPackageViewModels)
        {
            if (listPackageViewModels == null) yield return null;
            else
                foreach (var item in listPackageViewModels)
                {
                    yield return ModelToEntity(item);
                }
        }
    }
}