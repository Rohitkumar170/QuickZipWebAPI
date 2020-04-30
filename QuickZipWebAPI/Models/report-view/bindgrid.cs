using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.report_view
{
    public class bindgrid
    {

        public string SrNo { get; set;}
        public string Refrence1 { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string createdBy { get; set; }
        public string UpdatedBy { get; set; }
        public string FileUpdatedCount { get; set; }
        public string BankValidation { get; set; }
        public string AcValidation { get; set; }
        public string SavedCount { get; set; }
        public string EditCount { get; set; }
        public string entityName { get; set; }
    }
}