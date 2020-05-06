using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.nachtransactionpresentation
{
    public class NachTransactionMainGrid
    {
        public Nullable <Int64> RowNumber { get; set; } //com
        public string date { get; set; }
        public string FileNo { get; set; }  //com
        public string UserName { get; set; } //com
        public string CreatedOn { get; set; } //com
        public string UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }//com
        public string ApprovedBy { get; set; } //com
        public string ApprovedOn { get; set; }
        public DateTime LastStatus { get; set; }
        public string BankName { get; set; } //comp
        public string FileStatus { get; set; } //comp


        internal static object Cast<T>()
        {
            throw new NotImplementedException();
        }
    }
}