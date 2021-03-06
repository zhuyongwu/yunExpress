//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Entity
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using LighTake.Infrastructure.Seedwork;
    
    public partial class ReceivingExpens : Entity
    {
    
        ICollection<ReceivingExpenseInfo> _receivingExpenseInfos;
    
    
        public virtual int ReceivingExpenseID { get; set; }
        public virtual string WayBillNumber { get; set; }
        public virtual string CustomerOrderNumber { get; set; }
        public virtual string FinancialNote { get; set; }
        public virtual Nullable<int> Status { get; set; }
        public virtual string Auditor { get; set; }
        public virtual Nullable<System.DateTime> AuditorDate { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual System.DateTime LastUpdatedOn { get; set; }
        public virtual string LastUpdatedBy { get; set; }
        public virtual bool IsNoGet { get; set; }
        public virtual System.DateTime AcceptanceDate { get; set; }
    
        public virtual ICollection<ReceivingExpenseInfo> ReceivingExpenseInfos 
    	{
            get { return _receivingExpenseInfos  ?? (_receivingExpenseInfos  = new List<ReceivingExpenseInfo>()); }
            protected set { _receivingExpenseInfos  = value; }
        }
    
        public virtual WayBillInfo WayBillInfo { get; set; }
    }
}
