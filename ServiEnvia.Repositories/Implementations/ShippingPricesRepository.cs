using ServiEnvia.Data.EF.ConText;
using ServiEnvia.Repositories.Base;
using ServiEnvia.Repositories.Interfaces;
using System.Collections.Generic;

namespace ServiEnvia.Repositories.Implementations
{
    public class ShippingPricesRepository : EFBaseRepository, IShippingPricesRepository
    {
        public ShippingPricesRepository(ServiEnviaDBEntities dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<ShippingPrices> GetShippingPrices()
        {
            return _context.ShippingPrices;
        }
    }
}