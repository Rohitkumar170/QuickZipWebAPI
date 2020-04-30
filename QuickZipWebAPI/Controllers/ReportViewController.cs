using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZip.Models;
using QuickZip.Models.report_view;

namespace QuickZip.Controllers
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


        [HttpGet]
        [Route("api/ReportView/Bindgrid/{FromDate}/{ToDate}/{username}/{userid}")]
        public Dictionary<string, object> SearchData(string FromDate, string ToDate, string username, string UserId)
        {
            return objuser.SearchData(FromDate, ToDate, username, UserId);
        }
    }
}
