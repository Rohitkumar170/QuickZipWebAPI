using BusinessLibrary;
using QuickZipWebAPI.Entity;
using QuickZipWebAPI.Models.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace QuickZipWebAPI.Controllers
{
    public class FatehTestController : ApiController
    {
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        //[HttpGet]
        //[Route("api/FatehTest/GridBind/{Entityid}/{Pageno}")]
        //public Dictionary<string, object> GridBind1(string Entityid, string Pageno)
        //{
        //    try
        //    {

        //        var Result = Entity.Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_WebAPI]").With<Testmodel>().Execute("@QueryType", "GetLiveBank"));

        //        return Result;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}
        [HttpGet]
        [Route("api/FatehTest/GridBind/{Entityid}/{Pageno}")]
        public TestmodelMandateList GridBind1(string Entityid, string Pageno)
        {
            TestmodelMandateList obj = new TestmodelMandateList();
            List<Testmodel> dataList = new List<Testmodel>();
            List<TestmodelMandate> dataList1 = new List<TestmodelMandate>();
            try
            {

                var Result = dbcontext.MultipleResults("[dbo].[Sp_WebAPI]").With<Testmodel>().With<TestmodelMandate>().Execute("@QueryType", "GetLiveBank");
                dataList = Result.FirstOrDefault().Cast<Testmodel>().ToList();
                dataList1 = Result.LastOrDefault().Cast<TestmodelMandate>().ToList();
                //foreach (var Logindata in Result)
                //{
                //    dataList = Logindata.Cast<Testmodel>().ToList();
                //}
                obj.BankList=dataList;
                obj.StatusList = dataList1;
                return obj;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
