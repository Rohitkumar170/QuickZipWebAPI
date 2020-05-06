using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.EBulkUploadedData
{
    public class MainGridAttribute
    {
        public string DateOnMandate { get; set; }
        public string SponsorBank { get; set; }
        public string Utilitycode { get; set; }
        public string BankACNumber { get; set; }
        public string IFSC { get; set; }
        public string Amount { get; set; }
        public string Frequency { get; set; }
        public string DebitType { get; set; }
        public string RefNo1 { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailID { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string NameAsBankRrds1 { get; set; }  //   NameAsBankRrds2 NameAsBankRrds3
        public string CreatedOn { get; set; }
    }
}