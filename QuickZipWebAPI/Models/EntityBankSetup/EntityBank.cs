using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLibrary;
using System.Threading.Tasks;
using QuickZipWebAPI.Entity;
using System.Xml.Linq;
using System.Net.Http;
using System.Xml;

namespace QuickZipWebAPI.Models.EntityBankSetup
{
    public class EntityBank
    {
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        public Dictionary<string, object> getEntity()
        {
            try
            {


                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<Entity>().Execute("@QueryType", "GetEntity"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> getBank(string EntityId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<Bank>().Execute("@QueryType", "@EntityId", "GetBank",EntityId));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}