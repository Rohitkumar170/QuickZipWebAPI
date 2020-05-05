using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.EntityBankSetup
{
    public class Table1
    {
        public Nullable <Int64> EntityBankSetupId { get; set; }
        public Nullable<Int64> EntityId { get; set; }
        public Nullable<Int64> BankId { get; set; }
        public Nullable<Boolean> IsFileFormatXml { get; set; }
        public Nullable<Boolean> IsFileFormatExcel { get; set; }
        public Nullable<Boolean> IsFileFormatCsv { get; set; }
        public Nullable<Boolean> IsFileSendDaily { get; set; }
        public Nullable<Boolean> IsFileSendWeekly { get; set; }
        public Nullable<Boolean> IsFileSendMonthly { get; set; }
        public Nullable<Boolean> IsAdhoc { get; set; }
        public string TimeDuration { get; set; }
    }
}