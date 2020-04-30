using QuickZipWebAPI.Models.EntitySetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuickZipWebAPI.Controllers
{
    public class EntitySetupController : ApiController
    {
        EntitySetupDataAccess ESDA = new EntitySetupDataAccess();
        [HttpGet]
        [Route("api/BindCountryAndBank")]
        public Dictionary<string, object> BindCountryAndBankApi()
        {
            return ESDA.BindCountryAndBank();
        }
        [HttpGet]
        [Route("api/BingGrid")]
        public Dictionary<string, object> BingGridApi()
        {
            return ESDA.BingGridDataAccess();
        }
        [HttpGet]
        [Route("api/SaveData")]
        public Dictionary<string, object> SaveDataApi()
        {
            return ESDA.BingGridDataAccess();
        }
    }
}
