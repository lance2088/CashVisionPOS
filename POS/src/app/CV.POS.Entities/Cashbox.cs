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
    
    public partial class Cashbox
    {
        public Cashbox()
        {
            this.CashMovement = new HashSet<CashMovement>();
            this.CashboxStatus = new HashSet<CashboxStatus>();
        }
    
        public byte CashboxId { get; set; }
        public Nullable<byte> PremiseId { get; set; }
        public string Name { get; set; }
        public decimal CurrentAmount { get; set; }
    
        public virtual Premise Premise { get; set; }
        public virtual ICollection<CashMovement> CashMovement { get; set; }
        public virtual ICollection<CashboxStatus> CashboxStatus { get; set; }
    }
}
