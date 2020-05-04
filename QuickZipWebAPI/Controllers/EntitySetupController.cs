using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models.EntitySetup;

namespace QuickZip.Controllers
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
        [Route("api/BindGrid")]
        public Dictionary<string, object> BingGridApi()
        {
            return ESDA.BindGridDataAccess();
        }
        [HttpPost]
        [Route("api/SaveData")]
        public Dictionary<string, object> SaveDataApi([FromBody] AllFieldOfForm allFieldOfForm)
        {
            return ESDA.SaveDataDataAccess(allFieldOfForm);
        }
        [HttpGet]
        [Route("api/BindState/{CountryId}")]
        public Dictionary<string, object> BindStateApi(string CountryId)
        {
            return ESDA.BindStateDataAccess(CountryId);
        }
        [HttpGet]
        [Route("api/BindCity/{StateId}")]
        public Dictionary<string, object> BindCityApi(string StateId)
        {
            return ESDA.BindCityDataAccess(StateId);
        }
    }
}
