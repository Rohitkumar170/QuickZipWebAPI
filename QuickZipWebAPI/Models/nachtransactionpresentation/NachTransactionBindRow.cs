using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.nachtransactionpresentation
{
    public class NachTransactionBindRow
    {

        public string SponsorBankName { get; set; } //com
        //public string SponsorbankId { get; set; }
        public string Date { get; set; }  //com
        public string FileNo { get; set; } //com
                                           // public string AccountNumber { get; set; }
        public string createdby { get; set; }  //com
        public string SponsorBankcode { get; set; }
        public string IFSC { get; set; } //com
        public string UMRN { get; set; } //com
        public string CorporateAcNo { get; set; }  //com
        public string UtilityCode { get; set; } //com
        public string AccountNumber { get; set; } //com
        //public Int64 UserID { get; set; } //comp
        //public string presentmentchecker { get; set; } //comp
        //public string presentmentmaker { get; set; } //comp

    }
}