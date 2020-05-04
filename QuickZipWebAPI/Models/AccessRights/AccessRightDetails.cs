using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.AccessRights
{
    public class AccessRightDetails
    {

        public Nullable<Int64> LinkID { get; set; }
        public string LinkName { get; set; }
        public Nullable<bool> IsRead { get; set; }
        public Nullable<bool> IsCreate { get; set; }
        public Nullable<bool> IsEdit { get; set; }
        public string IconName { get; set; }
        public Nullable<Int32> result { get; set; }
    }
}