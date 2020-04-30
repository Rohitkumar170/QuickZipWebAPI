using BusinessLibrary;
using QuickZipWebAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace QuickZipWebAPI.Models.EntitySetup
{
    public class EntitySetupDataAccess
    {
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        public Dictionary<string, object> BindCountryAndBank()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<BindCountry>().With<BindBank>().With<EntityBusinessCode>().Execute("@QueryType", "BindCountry"));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> BingGridDataAccess()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<MainGrid>().Execute("@QueryType", "BindEntity"));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}