using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.BulkEmandate
{
    public class BulkEmandateAttribute
    {
        public Int64 Srno { get; set; }
        public string ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string FileName { get; set; }
        public string UploadedOn { get; set; }
        public string UserName { get; set; }
        public string TEUHID { get; set; }
        public Int64 ActivityId1 { get; set; }
    }
}