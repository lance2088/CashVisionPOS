//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CV.POS.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Unit
    {
        public Unit()
        {
            this.ProductUnit = new HashSet<ProductUnit>();
        }
    
        public byte UnitId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    
        public virtual ICollection<ProductUnit> ProductUnit { get; set; }
    }
}
