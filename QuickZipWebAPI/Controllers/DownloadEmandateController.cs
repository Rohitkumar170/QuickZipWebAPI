using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models.DownloadEmandate;
using QuickZipWebAPI.Models;
namespace QuickZipWebAPI.Controllers
{
    public class DownloadEmandateController : ApiController
    {

        DownloadEmandateaccesslayer obj = new DownloadEmandateaccesslayer();
        [HttpGet]
        [Route("api/DownloadEmandate/BankBind/{UserId}")]
        public Dictionary<string, object> BankBind(string UserId)
        {
            return obj.BankBind(UserId);
        }

        [HttpGet]
        [Route("api/DownloadEmandate/BindGridData/{FromDate}/{ToDate}/{Bank}/{UserId}")]
        public IEnumerable<DownLoadEmandateBind> BindGridData(string FromDate, string ToDate,string Bank, string UserId)
        {
            return obj.BindGridData(FromDate, ToDate, Bank, UserId);
        }
    }
}
