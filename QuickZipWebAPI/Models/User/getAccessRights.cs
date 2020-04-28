using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.User
{
    public class getAccessRights
    {
        public Int64 LinkID { get; set; }
        public Boolean IsRead { get; set; }
        public Boolean IsCreate { get; set; }
        public Boolean IsDownload { get; set; }
        public String ParallelUserIDs { get; set; }
        public int KotakDashBoard { get; set; }
    }
}
