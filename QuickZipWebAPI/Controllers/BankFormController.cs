using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models.BankForm;
using System.Threading.Tasks;


namespace QuickZipWebAPI.Controllers
{
    public class BankFormController : ApiController
    {
        BankFormData objbankform = new BankFormData();
        [HttpGet]
        [Route("api/BankForm/GetBankFormdata/{UserId}/{EntityId}")]
        public Dictionary<string, object> GetBankFormdata(string UserId,string EntityId)
        {
            return objbankform.GetPageLoaddata(UserId,EntityId);
        }

        [HttpPost]
        [Route("api/BankForm/CheckReference/{mandateId}/{EntityId}")]
        public Dictionary<string, object> CheckReference([FromBody] CheckReference checkreference, string mandateId, string EntityId)
        {
            return objbankform.CheckReference(checkreference, mandateId, EntityId);
        }
       
        [HttpPost]
        [Route("api/BankForm/SaveData/{UserId}/{EntityId}/{mandateid}")]
        public Dictionary<string, object> SaveData([FromBody] SaveData savedata, string UserId, string EntityId,string mandateid)
        {
            return objbankform.SaveData(savedata, UserId, EntityId,mandateid);
        }

        [HttpGet]
        [Route("api/BankForm/BindGrid/{UserId}")]
        public Dictionary<string, object> BindGrid(string UserId)
        {
            return objbankform.BindGrid(UserId);
        }

        [HttpGet]
        [Route("api/BankForm/Edit/{mandateid}/{UserId}/{EntityId}")]
        public Dictionary<string, object> Edit(string mandateid, string UserId, string EntityId)
        {
            return objbankform.Edit(mandateid, UserId, EntityId);
        }
    }
}
