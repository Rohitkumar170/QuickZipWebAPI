using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.DownloadMandate
{
    public class DownloadMandateGridDetails
    {
        public Boolean IsExcelMandateDownload { get; set; }
        public Boolean IsSnapMandateDownload { get; set; }
        public Boolean IsMobileData { get; set; }
        public string createdon { get; set; }
        public string JPGPath { get; set; }
        public string IsScan { get; set; }
        public string TIPPath { get; set; }
        public string IsPrint { get; set; }
        public Int64 mandateid { get; set; }
        public string BankName { get; set; }
        public string status { get; set; }
        public string Amount { get; set; }
        public string Code { get; set; }
        public string BankName1 { get; set; }
        public string DateOnMandate { get; set; }
        public string AcNo { get; set; }
        public string Refrence1 { get; set; }
        public string FromDate { get; set; }
        public string Customer1 { get; set; }
        public string DebitType { get; set; }
        public string Frequency { get; set; }
        public string ToDebit { get; set; }

    }
}