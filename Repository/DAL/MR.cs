//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class MR
    {
        public decimal RowAuto { get; set; }
        public Nullable<decimal> MRVersionId { get; set; }
        public string Sr { get; set; }
        public string PartNo { get; set; }
        public string Description { get; set; }
        public string Qty { get; set; }
        public string UnitCost { get; set; }
        public string ExtCost { get; set; }
        public string UnitPrice { get; set; }
        public string ExtPrice { get; set; }
    
        public virtual MRVersion MRVersion { get; set; }
    }
}
