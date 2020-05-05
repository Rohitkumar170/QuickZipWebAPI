using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models.Allumrn;
using QuickZipWebAPI.Models;

namespace QuickZip.Controllers
{
    public class AllUMRNController : ApiController
    {
        Allumrnaccesslayer obj = new Allumrnaccesslayer();

        [HttpGet]
        [Route("api/AllUMRN/GridBind1/{Entityid}/{Pageno}")]
        public Dictionary<string, object> GridBind1(string Entityid, string Pageno)
        {
            return obj.GridBind1(Entityid, Pageno);
        }

        [HttpPost]
        [Route("api/AllUMRN/SearchData")]
        public IEnumerable<GridData> SearchData([FromBody] GridData searchdata)
        {
            return obj.SearchData(searchdata);
        }



        [HttpPost]
        [Route("api/AllUMRN/SearchData1")]
        public Dictionary<string, object> SearchData1([FromBody] GridData searchdata)
        {
            return obj.SearchData1(searchdata);
        }
        [HttpPost]
        [Route("api/AllUMRN/AddUmrn1")]
        public Dictionary<string, object> AddUmrn1([FromBody] Insertumrn insertdata)
        {
            return obj.AddUmrn1(insertdata);
        }


        [HttpGet]
        [Route("api/AllUMRN/GridDataDetails/{UMRN}/{Entityid}")]
        public IEnumerable<GridDataDetails> GridDataDetails(string UMRN, string Entityid)
        {
            return obj.GridDataDetails(UMRN, Entityid);
        }
        //[HttpGet]
        //[Route("api/AllUMRN/GridDataDetails1/{UMRN}/{Entityid}")]
        //public Dictionary<string, object> GridDataDetails1(string UMRN, string Entityid)
        //{
        //    return obj.GridDataDetails1(UMRN, Entityid);
        //}



    }
}
