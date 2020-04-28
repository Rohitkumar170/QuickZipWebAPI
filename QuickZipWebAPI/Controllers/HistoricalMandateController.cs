using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models;
using QuickZipWebAPI.Models.HistoricalMandate;

namespace QuickZipWebAPI.Controllers
{
    public class HistoricalMandateController : ApiController
    {
        HistoricalMandateDataAccess objHMDA = new HistoricalMandateDataAccess();
        [HttpGet]
        [Route("api/BindData/DatesWise/{FromDate}/{ToDate}/{UserId}")]
        public IEnumerable<HistoricalMandateClass> GetDataApi(string FromDate, string ToDate,string UserId)
        {
            return objHMDA.GetDataFromDB(FromDate, ToDate, UserId);
        }
    }
}
