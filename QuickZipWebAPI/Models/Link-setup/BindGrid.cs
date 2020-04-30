using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.Link_setup
{
    public class BindGrid
    {
        public Nullable<Int64> LinkID { get; set; }
        public string LinkName { get; set; }
        public string CreatedOn { get; set; }
        public Nullable<Int32> OrderNo { get; set; }
        public Nullable<Int64> Srno { get; set; }

        public string url { get; set; }
        public string ModifiedOn { get; set; }
        public string Purpose { get; set; }
        public string IconName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int Result { get; set; }



    }
}