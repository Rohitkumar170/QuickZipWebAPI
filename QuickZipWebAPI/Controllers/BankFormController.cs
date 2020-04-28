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
    }
}
