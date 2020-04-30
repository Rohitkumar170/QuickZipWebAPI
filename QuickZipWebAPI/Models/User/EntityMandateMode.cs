using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.User
{
    public class EntityMandateMode
    {
        public Nullable<Boolean> EnableUserWise { get; set; }
        public Nullable<Boolean> EnableCancelUserWise { get; set; }
        public Int64 BankValidationUserCount { get; set; }
        public Int64 AcValidationUserCount { get; set; }
        
    }
}