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
        public Boolean chkEdit { get; set; }
        public Boolean chkCreate { get; set; }
        public Boolean chkDownload { get; set; }
        public Boolean chkView { get; set; }
        public Boolean chkRefEdit { get; set; }
        public string nachuser { get; set; }
        public Boolean chkUmrnHistory { get; set; }
        public Boolean chkUmrnUpload { get; set; }
        public Boolean chkAllUMRN { get; set; }
        public Boolean chknachpresentment { get; set; }
        public Boolean chkPresentMaker { get; set; }
        public Boolean chkPresentChecker { get; set; }
        public string maker { get; set; }
        public Int64 bankval { get; set; }
        public Int64 accountval { get; set; }
        public Boolean chkEnableCancel { get; set; }
        public string chkbulkuploadlink { get; set; }
        public string chkvideolink { get; set; }
        public int Result { get; set; }
        

    }
}