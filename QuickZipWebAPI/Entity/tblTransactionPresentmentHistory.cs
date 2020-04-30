//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickZipWebAPI.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTransactionPresentmentHistory
    {
        public long PHID { get; set; }
        public long PID { get; set; }
        public string FileNo { get; set; }
        public string BankName { get; set; }
        public string UMRN { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<long> TransheaderId { get; set; }
        public string ReferenceNo { get; set; }
        public string SponserBankCode { get; set; }
        public string UMRNStatus { get; set; }
        public string APIFileNo { get; set; }
        public string ReasonCode { get; set; }
    }
}