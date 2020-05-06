using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.EBulkUploadedData
{
    public class AccountRelatedIssueAttribute
    {
        public string MandateId { get; set; }
        public string Refrence1 { get; set; }
        public string Customer1 { get; set; }
        public string BankName { get; set; }
        public string AcNo { get; set; }
        public string Description { get; set; }
        public string BeniName { get; set; }
        public string Tab { get; set; }
    }
}