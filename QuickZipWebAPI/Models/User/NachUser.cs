using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.User
{
    public class NachUser
    {
        public Int64 UserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
    }
}