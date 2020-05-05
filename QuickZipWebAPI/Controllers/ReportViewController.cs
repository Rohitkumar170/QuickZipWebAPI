
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models.report_view;
using QuickZipWebAPI.Models;
using System.Threading.Tasks;

namespace QuickZipWebAPI.Controllers
{
    public class ReportViewController : ApiController
    {
       report_view_DataAccess objuser = new report_view_DataAccess();
        
       

        [HttpGet]
        [Route("api/ReportView/BindUser/{UserId}")]
        public Dictionary<string, object> BindUser(string UserId)
        {
            return objuser.BindUser(UserId);
        }


        //[HttpGet]
        //[Route("api/ReportView/SearchData/{FromDate}/{ToDate}/{userdrop}/{userid}")]
        //public Dictionary<string, object> SearchData(string FromDate, string ToDate, string userdrop, string UserId)
        //{
        //    return objuser.SearchData(FromDate,ToDate, userdrop, UserId);
        //}


        [HttpPost]
        [Route("api/ReportView/SearchData")]
        public Dictionary<string, object> SearchData([FromBody] bindgrid1 searchdata)
        {
           return objuser.SearchData(searchdata);
        }
    }
}
