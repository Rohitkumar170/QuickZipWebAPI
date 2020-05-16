using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.Test
{
    public class Testmodel
    {
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string LiveOnDebitCard { get; set; }
        public string LiveOnNetBanking { get; set; }
    }
    public class TestmodelMandate
    {
        public string status { get; set; }
        public string StatusDescription { get; set; }
    }
    public class TestmodelMandateList
    {
        public List<Testmodel> BankList   { get; set; }
        public List<TestmodelMandate> StatusList { get; set; }
       
    }
}