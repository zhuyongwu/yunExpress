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
    
    public partial class SensitiveTypeInfo : Entity
    {
    
        ICollection<CustomerOrderInfo> _customerOrderInfos;
    
    
        public virtual int SensitiveTypeID { get; set; }
        public virtual string SensitiveTypeName { get; set; }
        public virtual string Remark { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual System.DateTime LastUpdatedOn { get; set; }
        public virtual string LastUpdatedBy { get; set; }
        public virtual bool IsDelete { get; set; }
    
        public virtual ICollection<CustomerOrderInfo> CustomerOrderInfos 
    	{
            get { return _customerOrderInfos  ?? (_customerOrderInfos  = new List<CustomerOrderInfo>()); }
            protected set { _customerOrderInfos  = value; }
        }
    
    }
}