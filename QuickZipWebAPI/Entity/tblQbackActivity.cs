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
    
    public partial class tblQbackActivity
    {
        public long QBackActivityId { get; set; }
        public string FileName { get; set; }
        public Nullable<long> EntityId { get; set; }
        public string ActivityName { get; set; }
        public Nullable<long> UploadedBy { get; set; }
        public Nullable<System.DateTime> UploadedOn { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<bool> IsBulkMandate { get; set; }
        public Nullable<bool> IsMobileData { get; set; }
    }
}
