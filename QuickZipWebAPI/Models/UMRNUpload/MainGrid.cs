using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.UMRNUpload
{
    public class MainGrid
    {

        public Nullable<Int64> UploadHeaderId { get; set; }
        public string UploadNo { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UserName { get; set; }
        public Nullable<Int64> TotalCount { get; set; }
        public Nullable<Int64> SuccessCount { get; set; }
       
    }
}