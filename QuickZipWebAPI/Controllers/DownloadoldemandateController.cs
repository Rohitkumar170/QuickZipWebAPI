using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models.OldEmandate;
using QuickZipWebAPI.Models;
namespace QuickZipWebAPI.Controllers
{
    public class DownloadoldemandateController : ApiController
    {


        Downloadoldemandateaccesslayer obj = new Downloadoldemandateaccesslayer();
        [HttpGet]
        [Route("api/Downloadoldemandate/BankBind/{userid}")]
        public Dictionary<string, object> BankBind(string userid)
        {
            return obj.BankBind(userid);
        }


        

        [HttpGet]
        [Route("api/Downloadoldemandate/SearchData/{FromDate}/{ToDate}/{Bank}/{userid}")]
        public IEnumerable<Searchdata> SearchData(string FromDate, string ToDate, string Bank, string userid)
        {
            return obj.SearchData(FromDate, ToDate, Bank, userid);
        }
    }
}
