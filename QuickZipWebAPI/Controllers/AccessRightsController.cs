
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models.AccessRights;

namespace QuickZipWebAPI.Controllers
{
    public class AccessRightsController : ApiController
    {
        AccessRights objdmandate = new AccessRights();

        [HttpGet]
        [Route("api/AccessRights/getBindEntityDetails/{UserType}/{ReferenceId}")]
        public IEnumerable<AccessRightsEntityDetails> getBindEntityDetails(string UserType, string ReferenceId)
        {
            return objdmandate.BindEntityDetails(UserType, ReferenceId);
        }



        [HttpGet]
        [Route("api/AccessRights/getBindAccessRightDetails/{userid}/{UserType}")]
        public IEnumerable<AccessRightDetails> getBindAccessRightDetails(string userid, string UserType)
        {
            return objdmandate.BindAccessRightDetails(userid, UserType);
        }

        [HttpGet]

        [Route("api/AccessRights/getInsertdata/{userid}/{storeIsActive}/{storeIsRead}/{storeLinkID}/{CUserId}")]
        public Dictionary<string, object> getInsertdata(string userid, string storeIsActive, string storeIsRead, string storeLinkID, string CUserId)
        {
            //userid, storeIsActive, storeIsRead, storeLinkID
            return objdmandate.Insertdata(userid, storeIsActive, storeIsRead, storeLinkID, CUserId);
        }

    }
}
