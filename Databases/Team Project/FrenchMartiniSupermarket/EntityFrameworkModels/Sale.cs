//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int ReportId { get; set; }
        public int ProductId { get; set; }
        public double ProductQuantity { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public decimal ProductTotalSum { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Report Report { get; set; }
    }
}