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
    
    public partial class TblUserCategoryCode
    {
        public long UserCategoryCodeID { get; set; }
        public int Userid { get; set; }
        public string CategoryCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    }
}