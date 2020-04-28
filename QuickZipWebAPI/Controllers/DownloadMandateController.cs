using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models.DownloadMandate;
using QuickZipWebAPI.Models;


namespace QuickZipWebAPI.Controllers
{
    public class DownloadMandateController : ApiController
    {
        DownloadMandate objdmandate = new DownloadMandate();

        [HttpGet]
        [Route("api/DownloadMandate/getdropdownbank/{userId}")]
        public IEnumerable<DownloadMandateDetails> getdropdownbank(string userId)
        {
            return objdmandate.Binddropdownbank(userId);
        }

        [HttpGet]
        [Route("api/DownloadMandate/getBindGrid/{userID}/{ToDate}/{FromDate}/{sponsorbankcode}")]
        public IEnumerable<DownloadMandateGridDetails> getBindGrid(string userID, string ToDate, string FromDate, string sponsorbankcode)
        {
            return objdmandate.BindGrid(userID, ToDate, FromDate, sponsorbankcode);
        }

        [HttpGet]
        [Route("api/DownloadMandate/getBindGridRef/{userID}/{refNo}")]
        public IEnumerable<DownloadMandateGridDetails> getBindGridRef(string userID,string refNo)
        {
            return objdmandate.BindGridRef(userID, refNo);
        }

        //[HttpGet]
        //[Route("api/DownloadMandate/getRejectMandate/{userID}/{fromdate}/{todate}/{IsMandateID}/{rejectcomnt}")]
        //public IEnumerable<DownloadMandateGridDetails> getRejectMandate(string userID,string fromdate, string todate, string IsMandateID, string rejectcomnt)
        //{
        //    return objdmandate.RejectMandate(userID,fromdate, todate, IsMandateID, rejectcomnt);
        //}

        [HttpGet]
        [Route("api/DownloadMandate/getRejectMandate/{userID}/{fromdate}/{todate}/{selectMandateId}/{rejectcomnt}")]
        public Dictionary<string, object> getRejectMandate(string userID, string fromdate, string todate, string selectMandateId, string rejectcomnt)
        {
            return objdmandate.RejectMandate(userID, fromdate, todate, selectMandateId, rejectcomnt);
        }

        //[HttpGet]
        //[Route("api/BindData/DatesWise/{FromDate}/{ToDate}/{UserId}")]
        //public IEnumerable<HistoricalMandateClass> GetDataApi(string FromDate, string ToDate, string UserId)
        //{
        //    return objHMDA.GetDataFromDB(FromDate, ToDate, UserId);
        //}
    }
}
