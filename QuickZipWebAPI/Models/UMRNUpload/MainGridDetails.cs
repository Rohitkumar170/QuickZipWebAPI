using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.UMRNUpload
{
    public class MainGridDetails
    {
        public string legacyUploadedID { get; set; }
        public string UMRN { get; set; }
        public string Amount { get; set; }
        public string Refrence { get; set; }
        public string CustomerName { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string AccountType { get; set; }
        public string AccountNo { get; set; }
        public string IFSC { get; set; }
        public string AmountType { get; set; }
        public string Remark { get; set; }
    }
}