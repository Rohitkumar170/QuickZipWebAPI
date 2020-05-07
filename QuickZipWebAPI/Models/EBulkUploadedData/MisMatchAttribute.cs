using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.EBulkUploadedData
{
    public class MisMatchAttribute
    {
        public string statusofmandate { get; set; }    //bit
        public string MandateId { get; set; }
        public string Refrence1 { get; set; }
        public string Customer1 { get; set; }
        public string BankName { get; set; }
        public string AcNo { get; set; }
        public string BeniName { get; set; }
        public string Tab { get; set; }
        public Int32 TEUHID { get; set; }
        public Int64 ActiviyID { get; set; }
        public string NameAsBankRrds { get; set; }
        public Int32 CheckBoxStatus { get; set; }
        public Int32 UpdatedName { get; set; }
        public string Description { get; set; }
    }
}