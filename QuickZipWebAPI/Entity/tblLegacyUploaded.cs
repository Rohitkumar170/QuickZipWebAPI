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
    
    public partial class tblLegacyUploaded
    {
        public long TLUID { get; set; }
        public string legacyUploadedID { get; set; }
        public string UMRN { get; set; }
        public string Amount { get; set; }
        public string Refrence { get; set; }
        public string CustomerName { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string AccountType { get; set; }
        public string AccountNo { get; set; }
        public string IFSC { get; set; }
        public int IsSuccess { get; set; }
        public string Remark { get; set; }
        public string AmountType { get; set; }
    }
}
