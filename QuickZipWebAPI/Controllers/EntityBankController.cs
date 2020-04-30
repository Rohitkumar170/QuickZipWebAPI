using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models.EntityBankSetup;
using QuickZipWebAPI.Models;
using System.Xml;
using System.Data;
using System.Xml.Linq;

namespace QuickZipWebAPI.Controllers
{
    public class EntityBankController : ApiController
    {
        EntityBank objuser = new EntityBank();

        [HttpGet]
        [Route("api/EntityBank/getEntity")]
        public Dictionary<string, object> getEntity()
        {
           
            return objuser.getEntity();
        }

        [HttpGet]
        [Route("api/EntityBank/getBank/{EntityId}")]
        public Dictionary<string, object> getBank(string EntityId)
        {

            return objuser.getBank(EntityId);
        }

        //[HttpPost]
        //[Route("api/EntityBank/SaveData/{UserId}/{arrvalue}/{adhocarr}")]
        //public IEnumerable<EntityData> SaveData([FromBody] EntityData entity, string UserId, string arrvalue,string adhocarr)
        //{
        //    int fileformatxml = 0;
        //    int fileformatexcel = 0;
        //    int fileformatcsv = 0;

        //    if (entity.chkxml == true)
        //    {
        //        fileformatxml = 1;
        //    }
        //    else
        //    {
        //        fileformatxml = 0;
        //    }
            
        //    if (entity.chkexcel == true)
        //    {
        //        fileformatexcel = 1;
        //    }
        //    else
        //    {
        //        fileformatexcel = 0;
        //    }
            
        //    if (entity.chkcsv == true)
        //    {
        //        fileformatcsv = 1;
        //    }
        //    else
        //    {
        //        fileformatcsv = 0;
        //    }
        //    int FilesendDaily = 0;
        //    var FilesendWeekly = "0";
        //    var FilesendMonthly = "0";
        //    var FilesendSpecific = "0";
        //    if (jquery_1_11_3_min_p("input:radio[name=rdoDate]:checked").val() == 'D')
        //    {
        //        FilesendDaily = 1;
        //    }
        //    else if (jquery_1_11_3_min_p("input:radio[name=rdoDate]:checked").val() == 'W')
        //    {
        //        FilesendWeekly = 1;
        //    }
        //    else if (jquery_1_11_3_min_p("input:radio[name=rdoDate]:checked").val() == 'M')
        //    {
        //        FilesendMonthly = 1;
        //    }
        //    else if (jquery_1_11_3_min_p("input:radio[name=rdoDate]:checked").val() == 'A')
        //    {
        //        FilesendSpecific = 1;
        //    }


        //}

    }
}
