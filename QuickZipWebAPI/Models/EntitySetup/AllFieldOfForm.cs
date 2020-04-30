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
        public string AppID{ get; set; }
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
        public Boolean IsOverPrintMandate{ get; set; }
        public Boolean IsPhysicalMandateCh { get; set; }
        public Boolean IsRefCheck_Ch { get; set; }
        public Boolean IsRefNumerc { get; set; }
public Boolean IsSendEmail { get; set; }
        public Boolean IsShowMandateMode{ get; set; }
public Boolean IsThirdTransactionCh { get; set; }
public  Boolean  IsValidationCountEnableCh { get; set; }
public string MerchantKey { get; set; }
public string MobileNo { get; set; }
public string Name { get; set; }
public Boolean NetBankingCh { get; set; }
public Boolean Other_Ch { get; set; }
public string PinCode { get; set; }
public Boolean SB_Ch { get; set; }
public Boolean SB_NRE_Ch { get; set; }
public Boolean SB_NRO_Ch { get; set; }
public string  State { get; set; }
public string UserName { get; set; }
public Boolean chkIsAllowEManadte_Ch { get; set; }
public Boolean chkIsRefrence2Mandatory { get; set; }
public Boolean chkIsZipSure_Ch { get; set; }
public Boolean recheckthepresentmentfileCh { get; set; }
    }
}