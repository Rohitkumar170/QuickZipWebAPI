using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.User
{
    public class Users
    {
        
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string Type { get; set; }
        public Int64 sponsorbankcode { get; set; }
        public string categorycode { get; set; }
        public string emailsent { get; set; }
        public Nullable<Boolean> chkEdit { get; set; }
        public Nullable<Boolean> chkCreate { get; set; }
        public Nullable<Boolean> chkDownload { get; set; }
        public Nullable<Boolean> chkView { get; set; }
        public Nullable<Boolean> chkRefEdit { get; set; }
        public string nachuser { get; set; }
        public Nullable<Boolean> chkUmrnHistory { get; set; }
        public Nullable<Boolean> chkUmrnUpload { get; set; }
        public Nullable<Boolean> chkAllUMRN { get; set; }
        public Nullable<Boolean> chknachpresentment { get; set; }
        public Nullable<Boolean> chkPresentMaker { get; set; }
        public Nullable<Boolean> chkPresentChecker { get; set; }
        public string maker { get; set; }
        public Int64 bankval { get; set; }
        public Int64 accountval { get; set; }
        public Nullable<Boolean> chkEnableCancel { get; set; }
        public string chkbulkuploadlink { get; set; }
        public string chkvideolink { get; set; }
        public int Result { get; set; }
        

    }
}