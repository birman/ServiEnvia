using System;

namespace ServiEnvia.API.ViewModels
{
    public class ShippingPricesViewModel
    {
        public int Id { get; set; }
        public string OriginCity { get; set; }
        public string DestinationCity { get; set; }
        public Nullable<decimal> CostPerKilo { get; set; }
    }
}