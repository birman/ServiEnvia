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
    
    public partial class ShippingPrices
    {
        public int Id { get; set; }
        public string OriginCity { get; set; }
        public string DestinationCity { get; set; }
        public Nullable<decimal> CostPerKilo { get; set; }
    }
}
