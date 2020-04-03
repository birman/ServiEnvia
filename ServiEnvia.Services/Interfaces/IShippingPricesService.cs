using ServiEnvia.Data.EF.ConText;

namespace ServiEnvia.Services.Interfaces
{
    public interface IShippingPricesService
    {
        decimal CalculateShippingPrice(Package package);
    }
}