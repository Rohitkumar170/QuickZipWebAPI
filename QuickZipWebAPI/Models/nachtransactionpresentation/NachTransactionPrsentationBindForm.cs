using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.nachtransactionpresentation
{
    public class NachTransactionPrsentationBindForm
    {
    public string AccountNumber { get; set; }
        public string SponsorBankcode { get; set; }
        public string UtilityCode { get; set; }
        public string IFSC { get; set; }
        public string UserName { get; set; }
        public Nullable <Int32> UserID { get; set; }
        public double Bank_ID { get; set; }

        internal static object Cast<T>()
        {
            throw new NotImplementedException();
        }
    }
}