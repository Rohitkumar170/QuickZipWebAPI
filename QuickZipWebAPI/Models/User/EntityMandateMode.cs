using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.User
{
    public class EntityMandateMode
    {
        public Boolean EnableUserWise { get; set; }
        public Boolean EnableCancelUserWise { get; set; }
        public Int64 BankValidationUserCount { get; set; }
        public Int64 AcValidationUserCount { get; set; }
        
    }
}