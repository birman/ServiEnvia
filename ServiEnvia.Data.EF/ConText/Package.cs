//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiEnvia.Data.EF.ConText
{
    using System;
    using System.Collections.Generic;
    
    public partial class Package
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
    
        public virtual Customer Customer { get; set; }
        public virtual PackageStatus PackageStatus1 { get; set; }
    }
}
