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
        [Route("api/SaveData/{EntityId}")]
        public Dictionary<string, object> SaveDataApi([FromBody] AllFieldOfForm allFieldOfForm, string EntityId)
        {
            return ESDA.SaveDataDataAccess(allFieldOfForm, EntityId);
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
        [HttpGet]
        [Route("api/EditData/{EntityId}")]
        public Dictionary<string, object> EditDataApi(string EntityId)
        {
            return ESDA.EditDataDataAccess(EntityId);
        }
        [HttpPost]
        [Route("api/DeleteData/{EntityId}")]
        public Dictionary<string, object> DeleteDataApi([FromBody] MainGrid MainGrid,string EntityId)
        {
            return ESDA.DeleteDataDataAccess(MainGrid, EntityId);
        }

    }
}
