using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models;
using QuickZipWebAPI.Models.UMRN_History;

namespace QuickZipWebAPI.Controllers
{
    public class UMRNHistoryController : ApiController
    {
        UMRNHistoryDataAccess objUHDA = new UMRNHistoryDataAccess();
        [HttpPost]
        [Route("api/BindData")]
        public IEnumerable<UMRNHistoryClass> GetDataApi([FromBody] UMRNHistoryClass UMRNHistoryClass)
        {
            return objUHDA.GetDataFromDB(UMRNHistoryClass);
        }

       

    }
}
