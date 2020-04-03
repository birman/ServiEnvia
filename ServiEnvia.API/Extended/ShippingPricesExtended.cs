using ServiEnvia.API.ViewModels;
using ServiEnvia.Data.EF.ConText;
using System.Collections.Generic;

namespace ServiEnvia.API.Extended
{
    public static class ShippingPricesExtended
    {
        public static ShippingPricesViewModel EntityToModel(this ShippingPrices shippingPrices)
        {
            return new ShippingPricesViewModel
            {
                Id = shippingPrices.Id,
                OriginCity = shippingPrices.OriginCity,
                DestinationCity = shippingPrices.DestinationCity,
                CostPerKilo = shippingPrices.CostPerKilo
            };
        }

        public static IEnumerable<ShippingPricesViewModel> EntityToModel(this IEnumerable<ShippingPrices> listShippingPrices)
        {
            if (listShippingPrices == null) yield return null;
            else
                foreach (var item in listShippingPrices)
                {
                    yield return EntityToModel(item);
                }
        }

        public static ShippingPrices ModelToEntity(this ShippingPricesViewModel shippingPrices)
        {
            return new ShippingPrices
            {
                Id = shippingPrices.Id,
                OriginCity = shippingPrices.OriginCity,
                DestinationCity = shippingPrices.DestinationCity,
                CostPerKilo = shippingPrices.CostPerKilo
            };
        }

        public static IEnumerable<ShippingPrices> ModelToEntity(this IEnumerable<ShippingPricesViewModel> listShippingPricesViewModels)
        {
            if (listShippingPricesViewModels == null) yield return null;
            else
                foreach (var item in listShippingPricesViewModels)
                {
                    yield return ModelToEntity(item);
                }
        }
    }
}