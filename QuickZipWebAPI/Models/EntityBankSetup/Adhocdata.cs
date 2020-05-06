using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.EntityBankSetup
{
    public class Adhocdata
    {
        public IList<string> adhocarr { get; set; }
        public IList<string> arrsequence { get; set; }
        public string UserId { get; set; }
        
        public Nullable<Int64> ddlentity { get; set; }
        public Nullable<Int64> ddlbank { get; set; }
        public Nullable<Boolean> chkexcel { get; set; }
        public Nullable<Boolean> chkcsv { get; set; }
        public Nullable<Boolean> chkxml { get; set; }
        public string rdoDate { get; set; }
        public string ddlday { get; set; }
        
        public Nullable<Int64> ddldate { get; set; }
        public string txtdatepicker { get; set; }
        public string txtdatepicker1 { get; set; }
        public string txtdatepicker2 { get; set; }
        public string txtdatepicker3 { get; set; }
        public string txtdatepicker4 { get; set; }
        public string txtdatepicker5 { get; set; }
        public Nullable<int> txttotalcount { get; set; }
        public string presentmenttime { get; set; }
        public Nullable<Int32> result { get; set; }

    }
}