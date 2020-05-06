using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using BusinessLibrary;
using QuickZipWebAPI.Entity;
using QuickZipWebAPI.Models;

namespace QuickZipWebAPI.Models.EBulkUploadedData
{
    public class InvalidDataAttribute
    {
        public string Reference { get; set; }
        public string CustomerName { get; set; }
        public string BankacNumber { get; set; }
        public string IFSC { get; set; }
        public string Remark { get; set; }
    }
}