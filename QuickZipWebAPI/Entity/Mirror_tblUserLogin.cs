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
    
    public partial class Mirror_tblUserLogin
    {
        public long Mirror_UserId { get; set; }
        public long UserId { get; set; }
        public string EmailId { get; set; }
        public string UserType { get; set; }
        public Nullable<long> ReferenceId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordKey { get; set; }
        public Nullable<long> EntityId { get; set; }
        public string PhoneNo { get; set; }
        public Nullable<long> UserCode { get; set; }
        public long CreatedBy { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsLoginFirstTime { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public Nullable<bool> IsBulkMandate { get; set; }
        public Nullable<bool> IsMandate { get; set; }
        public Nullable<bool> IsMandateEdit { get; set; }
        public Nullable<bool> IsRefrenceEdit { get; set; }
        public Nullable<bool> IsOverPrintMandate { get; set; }
        public Nullable<bool> IsRefrenceCheck { get; set; }
        public string EmailSendTo { get; set; }
        public Nullable<bool> IsAllowFundTransfer { get; set; }
        public Nullable<bool> IsZipShoreABPS { get; set; }
        public Nullable<long> AppId { get; set; }
        public Nullable<long> PresentmentChecker { get; set; }
        public Nullable<long> PresentmentMaker { get; set; }
        public Nullable<bool> IsAccountvalidation { get; set; }
        public Nullable<bool> IsMobileApp { get; set; }
        public bool IsDefaultPswdChange { get; set; }
        public Nullable<bool> IsEnableCancel { get; set; }
        public Nullable<long> BankValidationUserCount { get; set; }
        public Nullable<long> AcValidationUserCount { get; set; }
        public int Mirror_CreatedBy { get; set; }
        public System.DateTime Mirror_CreatedOn { get; set; }
        public Nullable<bool> IsViewAll { get; set; }
    }
}
