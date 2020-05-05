using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QuickZipWebAPI.Models.report_view;
using BusinessLibrary;
using QuickZipWebAPI.Entity;
using System.Threading.Tasks;




namespace QuickZipWebAPI.Models.report_view
{
    public class report_view_DataAccess
    {
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        List<BindUser> dataList = new List<BindUser>();
        List<bindgrid> dataList1 = new List<bindgrid>();

        public Dictionary<string, object> BindUser(string UserId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[SP_Report]").With<BindUser>().Execute("@QueryType", "@UserId", "BindDdluser", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> SearchData(bindgrid1 bind)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[SP_Report]").With<bindgrid>().With<bindgrid1>().Execute("@QueryType", "@FromDate", "@ToDate", "@ddlUserId", "@UserId", "GetReportData", bind.Fromdate, bind.Todate, bind.alldropdown, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(bind.UserId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        //public Dictionary<string, object> SearchData(string FromDate, string ToDate, string Userdrop, string UserId)
        //{
        //    try
        //    {
        //        var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[SP_Report]").With<bindgrid>().With<bindgrid1>().Execute("@QueryType", "@FromDate", "@ToDate", "@ddlUserId", "@UserId", "GetReportData", FromDate, ToDate, Userdrop, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%")))));
        //        return Result;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}