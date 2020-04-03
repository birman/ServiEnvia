using ServiEnvia.Data.EF.ConText;
using ServiEnvia.Repositories.Interfaces;
using ServiEnvia.Services.Interfaces;
using System.Linq;

namespace ServiEnvia.Services.Implementations
{
    public class ShippingPricesService : IShippingPricesService
    {
        public IShippingPricesRepository _shippingPricesRepository;

        public ShippingPricesService(IShippingPricesRepository shippingPricesRepository)
        {
            _shippingPricesRepository = shippingPricesRepository;
        }

        private decimal? CalculateShippingPricesFromOriginAndDestination(string originCity, string destinationCity)
        {
            var shippingPrice = _shippingPricesRepository.GetShippingPrices().Where(x => x.OriginCity == originCity && x.DestinationCity == destinationCity).FirstOrDefault();

            if (shippingPrice != null)
            {
                return shippingPrice.CostPerKilo != null ?  shippingPrice.CostPerKilo : 0;
            }
            else
            {
                return 0;
            }
        }

        public decimal CalculateShippingPrice(Package package)
        {
            decimal shippingPrice = 0;
            decimal costPerKilo = (decimal)CalculateShippingPricesFromOriginAndDestination(package.OriginCity, package.DestinationCity);

            shippingPrice = (costPerKilo * package.Weight) + ((package.InsuredCost * (20)) / 100);

            return shippingPrice;

        }
    }
}