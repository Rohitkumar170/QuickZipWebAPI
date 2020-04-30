using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.EntityBankSetup
{
    public class EntityData
    {
        public Int64 ddlentity { get; set; }
        public Int64 ddlbank { get; set; }
        public Boolean chkexcel { get; set; }
        public Boolean chkcsv { get; set; }
        public Boolean chkxml { get; set; }
        public string rdoDate { get; set; }
        public Int64 ddlday { get; set; }
        public Int64 ddlsequence { get; set; }
        public Int64 ddldate { get; set; }
        public DateTime txtdatepicker { get; set; }
        public DateTime txtdatepicker1 { get; set; }
        public DateTime txtdatepicker2 { get; set; }
        public DateTime txtdatepicker3 { get; set; }
        public DateTime txtdatepicker4 { get; set; }
        public DateTime txtdatepicker5 { get; set; }
    }
}