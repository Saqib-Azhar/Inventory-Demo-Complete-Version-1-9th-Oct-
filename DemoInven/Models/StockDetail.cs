//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoInven.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StockDetail
    {
        public int Id { get; set; }
        public Nullable<int> StockId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> QuantityAdded { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
