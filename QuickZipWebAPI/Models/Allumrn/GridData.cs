using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.Allumrn
{
    public class GridData
    {
       
    
        public string ReferenceNumber { get; set; }
        public string Entityid { get; set; }
        public string Pageno { get; set; }
        public Int64 Srno { get; set; }
        public string UMRN { get; set; }
        public string CustomerName { get; set; }
        public string Refrence { get; set; }
        public decimal Amount { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string CreatedOn { get; set; }
        public string RecordType { get; set; }
        public string MandateStatus { get; set; }
        public string ErrorCode { get; set; }

    }
}