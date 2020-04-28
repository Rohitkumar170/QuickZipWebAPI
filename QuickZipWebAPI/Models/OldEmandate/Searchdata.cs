using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.OldEmandate
{
    public class Searchdata
    {  
        public string DebtorName { get; set; }
        public string InstructedAgentMemberName { get; set; }
        public string ConsumerReferenceNumber { get; set; }
        public string DebtorAccountNumber { get; set; }
        public string DebtorAgentID { get; set; }
        public string Collection { get; set; }
        public string MaximumAmount { get; set; }
        public string ServiceProvider { get; set; }
        public string Frequency { get; set; }
        public string DebtorAccountType { get; set; }
        public string CreationDateTime { get; set; }
        //public string ManDateID { get; set; }
        //public string FromDate { get; set; }
        //public string Todate { get; set; }
        //public string bankdrop { get; set; }


    }
}