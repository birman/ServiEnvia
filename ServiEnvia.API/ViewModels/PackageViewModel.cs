using ServiEnvia.Data.EF.ConText;

namespace ServiEnvia.API.ViewModels
{
    public class PackageViewModel
    {
        public long GuideId { get; set; }
        public string CustomerId { get; set; }
        public int PackageStatus { get; set; }
        public string RecipientId { get; set; }
        public string RecipientName { get; set; }
        public string RecipientLastName { get; set; }
        public string OriginCity { get; set; }
        public string DestinationCity { get; set; }
        public decimal Weight { get; set; }
        public decimal InsuredCost { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal InsuranceCost { get; set; }

        //public virtual Customer Customer { get; set; }
        //public virtual PackageStatus PackageStatus1 { get; set; }
    }
}