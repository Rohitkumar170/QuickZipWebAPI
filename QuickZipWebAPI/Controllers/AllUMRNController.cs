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
        public IEnumerable<GridData> SearchData(string Entityid, string Pageno)
        {
            return obj.SearchData(Entityid, Pageno);
        }

        [HttpPost]
        [Route("api/AllUMRN/SearchData")]
        public IEnumerable<GridData> SearchData([FromBody] GridData searchdata)
        {
            return obj.Searchbtn(searchdata);
        }




    }
}
