using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.EntitySetup
{
    public class AllFieldOfForm
    {
        public Boolean AadhaarCardCh { get; set; }
        public Boolean ActivePaymentModeCh { get; set; }
        public string Address { get; set; }
        public string AppID { get; set; }
        public Boolean CA_Ch { get; set; }
        public Boolean CC_Ch { get; set; }
        public Boolean Cash_Ch { get; set; }
        public Boolean Cheque_Ch { get; set; }
        public string City { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        public Boolean DebitCardCh { get; set; }
        public Boolean DemandDraft_Ch { get; set; }
        public Boolean Electronic_Ch { get; set; }
        public string Email { get; set; }
        public string EntityBCode { get; set; }
        public string EntityName { get; set; }
        public Boolean ISTodateMandatoryEnach_Ch { get; set; }
        public Boolean IsEMandate { get; set; }
        public Boolean IsOverPrintMandate { get; set; }
        public Boolean IsPhysicalMandateCh { get; set; }
        public Boolean IsRefCheck_Ch { get; set; }
        public Boolean IsRefNumerc { get; set; }
        public Boolean IsSendEmail { get; set; }
        public Boolean IsShowMandateMode { get; set; }
        public Boolean IsThirdTransactionCh { get; set; }
        public string MerchantKey { get; set; }
        public string MobileNo { get; set; }
        public string Name { get; set; }
        public Boolean NetBankingCh { get; set; }
        public Boolean Other_Ch { get; set; }
        public string PinCode { get; set; }
        public Boolean SB_Ch { get; set; }
        public Boolean SB_NRE_Ch { get; set; }
        public Boolean SB_NRO_Ch { get; set; }
        public string State { get; set; }
        public string UserName { get; set; }
        public Boolean chkIsAllowEManadte_Ch { get; set; }
        public Boolean chkIsRefrence2Mandatory { get; set; }
        public Boolean chkIsZipSure_Ch { get; set; }
        public Boolean recheckthepresentmentfileCh { get; set; }

        public string BankName { get; set; }
        public string BankCode { get; set; }
        public string UtilityCode { get; set; }
        public string Password { get; set; }
        public string confirmpassword { get; set; }
        public string AccountNumber { get; set; }
       // public Boolean ReCheck { get; set; }
        public Boolean CheckerRequire { get; set; }
        public string XmlModeType { get; set; }
        //public Boolean IsEnableUserCheck { get; set; }
        public Boolean ISEnableCancelUser { get; set; }
//public string dtEntityCode { get; set; }
        public string FullPath { get; set; }
        public string BankValidationAdminCount { get; set; }
        public string BankValidationUserCount { get; set; }
        public string AcValidationAdminCount { get; set; }
        public string AcValidationUserCount { get; set; }
        public Boolean EnableUserWise_Ch { get; set; }
        public Boolean IsValidationCountEnableCh { get; set; }
        public string InstructingMenmerId { get; set; }
        public string Type { get; set; }
        public string DebitType { get; set; }
        public string FrequencyType { get; set; }
        public string ToDebit { get; set; }
        public string Amount { get; set; }
        public Boolean Activate { get; set; }
        public string FileName1 { get; set; }
        public string FileName2 { get; set; }
        public string FileName3 { get; set; }
        public string FileName4 { get; set; }
        public string FileName5 { get; set; }
        public string FileName6 { get; set; }
        public Boolean FixedAmount_Ch { get; set; }
        public Boolean MaximumAmount_Ch { get; set; }
        public Boolean Half_Yearly_Ch { get; set; }
        public Boolean UntillCancelled_Ch { get; set; }
        public Boolean To_Ch { get; set; }
        public Boolean Monthly_Ch { get; set; }
        public Boolean Quarterly_Ch { get; set; }
        public Boolean Yearly_Ch { get; set; }
        public Boolean Presented_Ch { get; set; }
    }
}