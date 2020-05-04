using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.report_view
{
    public class bindgrid
    {

        public Int64 SrNo { get; set;}
        public string Refrence1 { get; set; }
        public Nullable<DateTime> CreatedOn { get; set; }
        public Nullable<DateTime> UpdatedOn { get; set; }
        public string createdBy { get; set; }
        public string UpdatedBy { get; set; }
        public Int32 FileUpdatedCount { get; set; }
        public Int32 BankValidation { get; set; }
        public Int32 AcValidation { get; set; }
        public Int32 SavedCount { get; set; }
        public Int32 EditCount { get; set; }
        public string entityName { get; set; }
    }
}