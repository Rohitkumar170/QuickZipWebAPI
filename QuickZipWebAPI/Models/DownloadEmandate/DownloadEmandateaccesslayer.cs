using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickZipWebAPI.Entity;
using BusinessLibrary;
namespace QuickZipWebAPI.Models.DownloadEmandate
{
    public class DownloadEmandateaccesslayer
    {
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        //  List<BankBind> dataList = new List<BankBind>();
        List<DownLoadEmandateBind>dataList = new List<DownLoadEmandateBind>();
        public Dictionary<string, object> BankBind(string UserId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<Downloademandatebank>().Execute("@QueryType", "@UserId", "UserBank", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<DownLoadEmandateBind> BindGridData(string FromDate, string ToDate, string Bank, string UserId)
        {
            try
            {
                //var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_DownloadEMandate]").With<DownLoadEmandateBind>().Execute("@QueryType", "@SponsorBankCode", "@strFromDate", "@strToDate", "grdEMandateDateWise", "Bank", "FromDate", "ToDate"));


                var Result = dbcontext.MultipleResults("[dbo].[Sp_DownloadEMandate]").With<DownLoadEmandateBind>().Execute("@QueryType", "@SponsorBankCode", "@strFromDate", "@strToDate", "@UserId", "grdEMandateDateWise", Bank, FromDate, ToDate, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))));
                foreach (var DownLoadEmandateBind in Result)
                {
                    dataList = DownLoadEmandateBind.Cast<DownLoadEmandateBind>().ToList();

                }
                return dataList;


                //return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}