using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.EBulkUploadedData
{
    public class ValidDataAttribute
    {
        //public string Reference { get; set; }
        //public string CustomerName { get; set; }
        //public string BankacNumber { get; set; }
        //public string IFSC { get; set; }
        //public string Remark { get; set; }
        public string statusofmandate { get; set; }
        public string MandateId { get; set; }
        public string Refrence1 { get; set; }
        public string Customer1 { get; set; }
        public string BankName { get; set; }
        public string AcNo { get; set; }
        public string Description { get; set; }
        public string BeniName { get; set; }
        public string Tab { get; set; }
        public Int32 TEUHID { get; set; }
        public Int64 ActiviyID { get; set; }
    }
}