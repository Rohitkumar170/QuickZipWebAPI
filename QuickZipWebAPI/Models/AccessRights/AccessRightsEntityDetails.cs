using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.AccessRights
{
    public class AccessRightsEntityDetails
    {
        public Nullable<Int64> userid { get; set; }
        public string username { get; set; }
        public string usertype { get; set; }
        public Nullable<Int64> entityid { get; set; }
    }
}