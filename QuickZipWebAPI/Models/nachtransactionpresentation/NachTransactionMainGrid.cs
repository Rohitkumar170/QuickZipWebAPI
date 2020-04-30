using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.nachtransactionpresentation
{
    public class NachTransactionMainGrid
    {
        public Int64 RowNumber { get; set; } //com
        //public DateTime date { get; set; }
        public string FileNo { get; set; }  //com
        public string UserName { get; set; } //com
        //public DateTime CreatedOn { get; set; }
        //public DateTime UpdatedOn { get; set; }
        //public string ApprovedBy { get; set; }
        //public Int64 ApprovedOn { get; set; }
        //public string LastStatus { get; set; }
        public string BankName { get; set; } //comp
        public string FileStatus { get; set; } //comp


        internal static object Cast<T>()
        {
            throw new NotImplementedException();
        }
    }
}