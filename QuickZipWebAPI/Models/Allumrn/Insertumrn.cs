using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.Allumrn
{
    public class Insertumrn
    {

      
        
        public string CreatedBy { get; set; }
        public string UserId { get; set; }
        public string EntityId { get; set; }
       
        public string UMRN { get; set; }
        public string CustomerName { get; set; }
        public string ReferenceNumber { get; set; }
        public string Amount { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
     
    }
}