using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace QuickZipWebAPI.Models.User
{
    public class UserData
    {
        public string IsDeleted { get; set; }
        public Int64 Srno { get; set; }
        public Int64 UserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string Type { get; set; }
        public Int64 PresentmentMaker { get; set; }
        public Int64 PresentmentChecker { get; set; }
        public Int64 BankValidationUserCount { get; set; }
        public Int64 AcValidationUserCount { get; set; }
        public Nullable<Boolean> IsZipShoreABPS { get; set; }
        public Nullable<Boolean> IsAllowFundTransfer { get; set; }
        public string UserType { get; set; }
        public Nullable<Boolean> IsMandate { get; set; }
        public Nullable<Boolean> IsBulkMandate { get; set; }
        public Nullable<Boolean> IsMandateEdit { get; set; }
        public Nullable<Boolean> IsRefrenceEdit { get; set; }
        public string EmailSendTo { get; set; }
        public Nullable<Boolean> IsEnableCancel { get; set; }
        public Nullable<Boolean> IsViewAll { get; set; }
        
        
       

    } 
}