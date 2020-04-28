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
    
    public partial class tblMandate
    {
        public long MandateId { get; set; }
        public string Frequency { get; set; }
        public string DebitType { get; set; }
        public Nullable<System.DateTime> DateOnMandate { get; set; }
        public string Refrence1 { get; set; }
        public string BankReturnCustNme { get; set; }
        public string IsBankOrMandateName { get; set; }
        public string Refrence2 { get; set; }
        public string PhoneNumber { get; set; }
        public string Customer2 { get; set; }
        public Nullable<long> ScanCount { get; set; }
        public Nullable<long> PrintCount { get; set; }
        public string TIPPath { get; set; }
        public string JPGPath { get; set; }
        public string Customer3 { get; set; }
        public string Customer1 { get; set; }
        public string EntityId { get; set; }
        public Nullable<System.DateTime> Todate { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public string AmountRupeesInWords { get; set; }
        public Nullable<decimal> AmountRupees { get; set; }
        public string BankName { get; set; }
        public string EmailId { get; set; }
        public string AcNo { get; set; }
        public string IFSC { get; set; }
        public string ToDebit { get; set; }
        public Nullable<double> MICR { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string UtilityCode { get; set; }
        public string SponsorbankCode { get; set; }
        public Nullable<long> ActivityId { get; set; }
        public Nullable<bool> IsExcelMandateDownload { get; set; }
        public bool IsSnapMandateDownload { get; set; }
        public bool IsRejected { get; set; }
        public string RejectedReason { get; set; }
        public string EnachMobileNo { get; set; }
        public string EnachAdharNo { get; set; }
        public string EnachEmail { get; set; }
        public Nullable<bool> Enach { get; set; }
        public Nullable<long> ConsentId { get; set; }
        public Nullable<bool> IsFirstValidation { get; set; }
        public Nullable<bool> IsSecondValidation { get; set; }
        public string FileUploadedCount { get; set; }
        public Nullable<long> BankValidationUserCount { get; set; }
        public Nullable<long> BankValidationAdminCount { get; set; }
        public Nullable<long> AcValidationUserCount { get; set; }
        public Nullable<long> AcValidationAdminCount { get; set; }
        public Nullable<bool> IsFinalReject { get; set; }
        public string AutoRejectReason { get; set; }
        public string XmlPath { get; set; }
        public string MandateMode { get; set; }
        public Nullable<bool> IsSubmitted { get; set; }
        public Nullable<bool> IsMandate { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public Nullable<long> EmailSendCount { get; set; }
        public Nullable<long> PhoneNumberCount { get; set; }
        public string ErrorCode { get; set; }
        public Nullable<bool> IsPhysical { get; set; }
        public string EnachMessageId { get; set; }
        public Nullable<bool> IsFinalTransaction { get; set; }
        public Nullable<bool> IsFundTransfered { get; set; }
        public Nullable<bool> IsESPSecondTime { get; set; }
        public string MandateStatus { get; set; }
        public string MandateType { get; set; }
        public string UMRN { get; set; }
        public string MandateNPCIStatus { get; set; }
        public string NPCIRejectReason { get; set; }
        public Nullable<bool> IsSendToBank { get; set; }
        public Nullable<bool> IsSucessBankValidationFlag { get; set; }
        public string EMandatetype { get; set; }
        public string QRCodeImagePath { get; set; }
        public string AcceptRefNo { get; set; }
        public string NPCIErrorDesc { get; set; }
        public Nullable<bool> IsAggregator { get; set; }
        public string IsAggregatorValue { get; set; }
        public Nullable<long> EmailCount { get; set; }
        public Nullable<long> SmsCount { get; set; }
        public string MSGId { get; set; }
        public string NPCIMsgId { get; set; }
        public Nullable<long> ULUID { get; set; }
        public string CategoryCode { get; set; }
        public Nullable<bool> IsStatusPosted { get; set; }
        public Nullable<System.DateTime> SendToBankDate { get; set; }
        public Nullable<long> StatusId { get; set; }
        public string VPAId { get; set; }
    }
}
