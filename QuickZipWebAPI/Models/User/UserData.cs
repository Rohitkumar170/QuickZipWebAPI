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
        public Boolean IsZipShoreABPS { get; set; }
        public Boolean IsAllowFundTransfer { get; set; }
        public string UserType { get; set; }
        public Boolean IsMandate { get; set; }
        public Boolean IsBulkMandate { get; set; }
        public Boolean IsMandateEdit { get; set; }
        public Boolean IsRefrenceEdit { get; set; }
        public string EmailSendTo { get; set; }
        public Boolean IsEnableCancel { get; set; }
        public Boolean IsViewAll { get; set; }
        
        
       

    } 
}