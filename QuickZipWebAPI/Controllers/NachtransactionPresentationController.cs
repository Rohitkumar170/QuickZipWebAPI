using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models.nachtransactionpresentation;
using QuickZipWebAPI.Models;

namespace QuickZipWebAPI.Controllers
{
    public class NachtransactionPresentationController : ApiController
    {
        nachtransactionpresentationaccesslayer obj = new nachtransactionpresentationaccesslayer();
        [HttpGet]
        [Route("api/NachtransactionPresentation/BankBind/{UserId}/{EntityId}")]
        public IEnumerable<Nachtransactionpresentation> BankBind(string UserId, string EntityId)
        {
            return obj.BankBind(UserId, EntityId);
        }
        [HttpGet]
        [Route("api/NachtransactionPresentation/CheckUser/{UserId}/{EntityId}")]
        public Dictionary<string, object> CheckUser(string UserId, string EntityId)
        {
            return obj.CheckUser(UserId, EntityId);
        }
        [HttpGet]
        [Route("api/NachtransactionPresentation/BindGridForm/{Bank}/{UserId}/{EntityId}")]
        public IEnumerable<NachTransactionPrsentationBindForm> BindGridForm(string Bank,string UserId, string EntityId)
        {
            return obj.BindGridForm(Bank,UserId, EntityId);
        }
        [HttpGet]
        [Route("api/NachtransactionPresentation/BindMainGrid/{UserId}")]
        public IEnumerable<NachTransactionMainGrid> BindMainGrid(string UserId)
        {
            return obj.BindMainGrid(UserId);
        }

        [HttpGet]
        [Route("api/NachtransactionPresentation/BindUMRN/{UserId}/{EntityId}/{PresDate}")]
        public IEnumerable<NachTransactionBindUMRN> BindUMRN(string UserId, string EntityId, string PresDate)
        {
            return obj.BindUMRN(UserId, EntityId, PresDate);
        }

        [HttpGet]
        [Route("api/NachtransactionPresentation/BindRefrence/{UserId}/{EntityId}/{PresDate}")]
        public IEnumerable<NachTransactionBindRef> BindRefrence(string UserId, string EntityId, string PresDate)
        {
            return obj.BindRefrence(UserId, EntityId, PresDate);
        }
        [HttpGet]
        [Route("api/NachtransactionPresentation/BindOnRowdblClick/{UserId}/{EntityId}/{FileNo}")]
        public IEnumerable<NachTransactionBindRow> BindOnRowdblClick(string UserId, string EntityId, string FileNo)
        {
            return obj.BindOnRowdblClick(UserId, EntityId, FileNo);
        }
        [HttpGet]
        [Route("api/NachtransactionPresentation/BindUMRNOnchange/{UserId}/{EntityId}/{RefrenceNo}")]
        public IEnumerable<NachTransactionUMRNOnChange> BindUMRNOnchange(string UserId, string EntityId, string RefrenceNo)
        {
            return obj.BindUMRNOnchange(UserId, EntityId, RefrenceNo);
        }
        [HttpGet]
        [Route("api/NachtransactionPresentation/BindRefOnchange/{UserId}/{EntityId}/{RefrenceNo}")]
        public IEnumerable<NachTransactionBindRefOnChange> BindRefOnchange(string UserId, string EntityId, string RefrenceNo)
        {
            return obj.BindRefOnchange(UserId, EntityId, RefrenceNo);
        }
    }
}
