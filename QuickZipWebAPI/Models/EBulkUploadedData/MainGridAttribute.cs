using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.EBulkUploadedData
{
    public class MainGridAttribute
    {
        public int ULUID {get;set;}
        public string ExlUploadedID { get; set; }
        public string DateOnMandate { get; set; }
        public string SponsorBank { get; set; }
        public string Utilitycode { get; set; }
        public string IWehereby { get; set; }
        public string ToDebit { get; set; }
        public string BankACNumber { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string OrMICR { get; set; }
        public string Amount { get; set; }
        public string Frequency { get; set; }
        public string DebitType { get; set; }
        public string RefNo1 { get; set; }
        public string RefNo2 { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailID { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string NameAsBankRrds1 { get; set; }
        public string NameAsBankRrds2 { get; set; }
        public string NameAsBankRrds3 { get; set; }
        public Nullable<Int64> EntityID { get; set; }
        public Nullable<Int64> CreatedBy { get; set; }                                        //   NameAsBankRrds2 NameAsBankRrds3
        public string CreatedOn { get; set; }
        public Nullable<Int64> UpdatedBy { get; set; }
        public DateTime UpdateOn { get; set; }
        public Boolean IsActive { get; set; }             //bit
        public Boolean IsDeleted { get; set; }              //bit
        public int TEUHID { get; set; }
    }
}