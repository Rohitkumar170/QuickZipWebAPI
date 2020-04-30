using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.nachtransactionpresentation
{
    public class NachTransactionBindRefOnChange
    {
        public string Refrence1 { get; set; }
        public string Refrence { get; set; }
        public decimal Amount { get; set; }
        public string DebitType { get; set; }
    }
}