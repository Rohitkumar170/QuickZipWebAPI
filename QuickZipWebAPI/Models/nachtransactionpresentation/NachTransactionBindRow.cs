using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.nachtransactionpresentation
{
    public class NachTransactionBindRow
    {

        public string SponsorBankName { get; set; } //com
        public Int64  SponsorbankId { get; set; }
       // public string Date { get; set; }  //com
        public string FileNo { get; set; } //com
        public string AccountNumber { get; set; }
       // public string createdby { get; set; }
        public string SponsorBankcode { get; set; }
        public string IFSC { get; set; }
        public string UtilityCode { get; set; }
        public Int64 UserID { get; set; } //comp
        public string presentmentchecker { get; set; } //comp
        public string presentmentmaker { get; set; } //comp
        
    }
}