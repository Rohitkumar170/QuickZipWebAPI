using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models.Allumrn;
using QuickZipWebAPI.Models;

namespace QuickZipWebAPI.Controllers
{
    public class AllUMRNController : ApiController
    {
        Allumrnaccesslayer obj = new Allumrnaccesslayer();
        [HttpGet]
        [Route("api/AllUMRN/GridBind/{Entityid}/{Pageno}")]
        public IEnumerable<GridData> GridBind(string Entityid, string Pageno)
        {
            return obj.GridBind(Entityid, Pageno);
        }
        [HttpPost]
        [Route("api/AllUMRN/SearchData")]
        public IEnumerable<GridData> SearchData([FromBody] GridData searchdata)
        {
            return obj.SearchData(searchdata);
        }

        //public Dictionary<string, object> AddUmrn([FromBody] Insertumrn insertdata)
        //{
        //    return obj.AddUmrn(insertdata);
        //}

        [HttpPost]
        [Route("api/AllUMRN/AddUmrn")]
        public IEnumerable<Insertumrn> AddUmrn([FromBody] Insertumrn insertdata)
         {
            return obj.AddUmrn(insertdata);
        }

        [HttpGet]
        [Route("api/AllUMRN/GridDataDetails/{UMRN}/{Entityid}")]
        public IEnumerable<GridData> GridDataDetails(string UMRN, string Entityid)
        {
            return obj.GridDataDetails(UMRN, Entityid);
        }
        //[Route("api/AllUMRN/AddUmrn/{NEWUMRN}/{Customername}/{ReferenceNumber}/{Amount}/{FromDate}/{ToDate}/{Entityid}/{Userid}/{CreatedBy}")]
        //public Dictionary<string, object> AddUmrn(string NEWUMRN, string Customername, string ReferenceNumber, string Amount, string FromDate, string ToDate, string Entityid, string Userid, string CreatedBy )
        //{
        //    //NEWUMRN, Customername, ReferenceNumber, Amount, FromDate, ToDate, Entityid, Userid, CreatedBy
        //    return obj.AddUmrn(NEWUMRN, Customername, ReferenceNumber, Amount, FromDate, ToDate, Entityid, Userid, CreatedBy);
        //}

    }
}
