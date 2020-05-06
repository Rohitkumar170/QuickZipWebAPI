using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.EBulkUploadedData
{
    public class ValidDataAttribute
    {
        public string Reference { get; set; }
        public string CustomerName { get; set; }
        public string BankacNumber { get; set; }
        public string IFSC { get; set; }
        public string Remark { get; set; }
    }
}