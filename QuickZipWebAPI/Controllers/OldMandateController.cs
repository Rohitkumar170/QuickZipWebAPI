
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models;
using QuickZipWebAPI.Models.OldMandate;



namespace QuickZipWebAPI.Controllers
{
    public class OldMandateController : ApiController
    {
        OldMandateClass oldmandcls = new OldMandateClass();
       // downloadOldMandateTableAttibute downlodman = new downloadOldMandateTableAttibute();

        [HttpGet]
        [Route("api/OldMandate/GetDataByUID/{UserId}")]
        public IEnumerable<OldMandateAttribute> GetDataByUID(string UserId)
        {
            return oldmandcls.GetUserBankData(UserId);
        }

        [HttpGet]
        [Route("api/OldMandate/GetDataByReference/{UserId}/{Refrence1}")]
        public IEnumerable<OldMandateAttribute> GetDataByReference(string UserId, string Refrence1)
        {
            return oldmandcls.GetAllDataByRefrence(UserId, Refrence1);
           
        }


        [HttpGet]
        [Route("api/OldMandate/GetDataByDate/{UserId}/{strFromDate}/{strToDate}/{SponsorBankCode}")]
        public IEnumerable<OldMandateAttribute> GetDataByDate(  string UserId, string strFromDate, string strToDate, string SponsorBankCode)
        {
            return oldmandcls.GetAllDataByDate(UserId, strFromDate, strToDate, SponsorBankCode);
        }


        [HttpGet]
        [Route("api/OldMandate/RejectDt/{FromDate}/{ToDate}/{RejectedReason}/{UserId}/{selectMandateId}")]
        public IEnumerable<OldMandateAttribute> RejectDt(string FromDate, string ToDate, string RejectedReason, string UserId, string selectMandateId)
        {
            return oldmandcls.RejectData(FromDate, ToDate, RejectedReason, UserId, selectMandateId);
        }

    }
}
