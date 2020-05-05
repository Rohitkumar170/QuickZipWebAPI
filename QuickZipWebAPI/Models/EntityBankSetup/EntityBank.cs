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
        List<Adhocdata> dataList = new List<Adhocdata>();
        List<EntityData> dataList1 = new List<EntityData>();
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

        public Dictionary<string, object> EditData(string EntityId, string BankId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_EntityBankSetup]").With<Table1>().With<Table2>().With<Table3>().Execute("@QueryType", "@EntityId", "@BankId", "GetData", EntityId, BankId));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Adhocdata> SaveData(Adhocdata adhocdata, string UserId, int fileformatxml, int fileformatexcel, int fileformatcsv, int FilesendDaily, int FilesendWeekly, int FilesendMonthly, int FilesendSpecific, string dtDate, string dtFileSequence)
        {
            try
            {


                var Result = dbcontext.MultipleResults("[dbo].[Sp_EntityBankSetup]").With<Adhocdata>().Execute("@QueryType", "@dtFileSequence", "@EntityId", "@BankId"
                , "@fileformatxml", "@fileformatexcel", "@fileformatcsv", "@FilesendDaily",
         "@FilesendWeekly", "@FilesendMonthly", "@FilesendSpecific", "@TimeDuration", "@dtDate", "@UserId", "SaveData"
                       , dtFileSequence, adhocdata.ddlentity.ToString(), adhocdata.ddlbank.ToString(), fileformatxml.ToString(), fileformatexcel.ToString(), fileformatcsv.ToString(), FilesendDaily.ToString(),
             FilesendWeekly.ToString(), FilesendMonthly.ToString(), FilesendSpecific.ToString(), adhocdata.presentmenttime, dtDate, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))));

                foreach (var entitydata in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = entitydata.Cast<Adhocdata>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<Adhocdata> UpdateData(Adhocdata adhocdata, string UserId, int fileformatxml, int fileformatexcel, int fileformatcsv, int FilesendDaily, int FilesendWeekly, int FilesendMonthly, int FilesendSpecific, string dtDate, string dtFileSequence, int Id)
        {
            try
            {


                var Result = dbcontext.MultipleResults("[dbo].[Sp_EntityBankSetup]").With<Adhocdata>().Execute("@QueryType", "@dtFileSequence", "@EntityId", "@BankId"
                , "@fileformatxml", "@fileformatexcel", "@fileformatcsv", "@FilesendDaily",
         "@FilesendWeekly", "@FilesendMonthly", "@FilesendSpecific", "@TimeDuration", "@dtDate", "@EntityBankId", "@UserId", "UpdateData"
                       , dtFileSequence, adhocdata.ddlentity.ToString(), adhocdata.ddlbank.ToString(), fileformatxml.ToString(), fileformatexcel.ToString(), fileformatcsv.ToString(), FilesendDaily.ToString(),
             FilesendWeekly.ToString(), FilesendMonthly.ToString(), FilesendSpecific.ToString(), adhocdata.presentmenttime, dtDate, Id.ToString(), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))));

                foreach (var entitydata in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = entitydata.Cast<Adhocdata>().ToList();
                }
                 return dataList;
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}