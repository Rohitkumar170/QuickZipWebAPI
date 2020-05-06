using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models;
using QuickZipWebAPI.Models.EBulkUploadedData;

namespace QuickZipWebAPI.Controllers
{
    public class EBulkUploadedDataController : ApiController
    {
        EBulkUploadedDataClass EBulkUpdDt = new EBulkUploadedDataClass();
        [HttpPost]
        [Route("api/EBulkUploadedData/GetAllData/{ActivityID}/{UserId}/{EntityId}/{TEUHID}/{LoadData}")]

       // string ActivityID, string UserId, string EntityId, string TEUHID, string LoadData
       public Dictionary<string,object> GetAllData(string ActivityID, string UserId, string EntityId, string TEUHID, string LoadData)
        {
          return  EBulkUpdDt.GetData(ActivityID, UserId, EntityId, TEUHID, LoadData);
        }
    }
}
