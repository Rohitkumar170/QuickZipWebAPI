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
    
    public partial class tblStatusMaster
    {
        public long StatusId { get; set; }
        public string MandateStatus { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<long> IsActive { get; set; }
        public Nullable<long> IsDeleted { get; set; }
    }
}
