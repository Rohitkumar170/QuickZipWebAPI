using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.User
{
    public class UserReport
    {
        public Int64 SrNo { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
}