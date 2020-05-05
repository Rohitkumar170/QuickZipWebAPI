using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickZipWebAPI.Entity;
using BusinessLibrary;
namespace QuickZipWebAPI.Models.OldEmandate
{
    public class Downloadoldemandateaccesslayer
    {
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        List<Searchdata> dataList = new List<Searchdata>();
        public Dictionary<string, object> BankBind(string userid)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<BankBind>().Execute("@QueryType", "@UserId", "UserBank", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(userid.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Searchdata> SearchData(string FromDate, string ToDate, string Bank, string userid)
        {
            try
            {
                var Result = dbcontext.MultipleResults("[dbo].[Sp_DownloadEMandate]").With<Searchdata>().Execute("@QueryType", "@strToDate", "@strFromDate", "@UserId", "@SponsorBankCode", "grdEMandateDateWise", ToDate, FromDate, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(userid.Replace("_", "%"))), Bank);
                foreach (var employe in Result)
                {
                   
                    dataList = employe.Cast<Searchdata>().ToList();


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