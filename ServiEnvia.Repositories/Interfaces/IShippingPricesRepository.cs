using ServiEnvia.Data.EF.ConText;
using System.Collections.Generic;

namespace ServiEnvia.Repositories.Interfaces
{
    public interface IShippingPricesRepository
    {
        IEnumerable<ShippingPrices> GetShippingPrices();
    }
}