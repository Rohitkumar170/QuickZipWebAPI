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
    
    public partial class tblMandateActivityDate
    {
        public long ActivitydateId { get; set; }
        public Nullable<long> MandateId { get; set; }
        public Nullable<System.DateTime> BankValidationOn { get; set; }
        public Nullable<long> BankValidationby { get; set; }
        public Nullable<System.DateTime> AccountValidationOn { get; set; }
        public Nullable<long> AccountValidationby { get; set; }
        public Nullable<System.DateTime> PrintedOn { get; set; }
        public Nullable<long> Printedby { get; set; }
        public Nullable<System.DateTime> UploadedOn { get; set; }
        public Nullable<long> Uploadedby { get; set; }
        public Nullable<System.DateTime> SubmitToBankDate { get; set; }
        public Nullable<long> SubmitToBankby { get; set; }
        public Nullable<System.DateTime> SendToBankDate { get; set; }
        public Nullable<long> SendToBankby { get; set; }
        public Nullable<System.DateTime> ResponseUploadedOn { get; set; }
        public Nullable<long> ResponseUploadedby { get; set; }
        public Nullable<System.DateTime> UMRNGeneratedOn { get; set; }
        public Nullable<long> UMRNGeneratedby { get; set; }
        public Nullable<System.DateTime> RegistrationStatusDate { get; set; }
        public Nullable<long> RegistrationStatusby { get; set; }
        public Nullable<System.DateTime> LastSMSSendOn { get; set; }
        public Nullable<long> LastSMSSendby { get; set; }
        public Nullable<System.DateTime> LastEmailSendOn { get; set; }
        public Nullable<long> LastEmailSendby { get; set; }
        public Nullable<System.DateTime> ProceedClickOn { get; set; }
        public Nullable<long> ProceedClickby { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> EMandateSelectedOn { get; set; }
        public Nullable<long> EMandateSelectedby { get; set; }
        public Nullable<System.DateTime> ExcelDownloadedon { get; set; }
        public Nullable<long> ExcelDownloadedBy { get; set; }
        public Nullable<System.DateTime> ImageDownloadedOn { get; set; }
        public Nullable<long> ImageDownloadedBy { get; set; }
        public Nullable<System.DateTime> CancelOn { get; set; }
        public Nullable<long> CancelBy { get; set; }
        public string SMSStatus { get; set; }
        public Nullable<System.DateTime> DeliveryOn { get; set; }
        public string SMSRejectionReason { get; set; }
        public Nullable<System.DateTime> RejectedbySponsorBankOn { get; set; }
        public Nullable<long> RejectedbySponsorBankby { get; set; }
        public Nullable<System.DateTime> AcceptedbySponsorBankOn { get; set; }
        public Nullable<long> AcceptedbySponsorBankby { get; set; }
        public Nullable<System.DateTime> eManadateJourneyFailedOn { get; set; }
    }
}
