using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLibrary;
using QuickZipWebAPI.Entity;
using System.Threading.Tasks;

namespace QuickZipWebAPI.Models.UMRNUpload
{
    public class UMRNUpload
    {
        List<MainGrid> dataList = new List<MainGrid>();
      
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();

        public Dictionary<string, object> BindGrid(string EntityId)
        {
          
            try
            {

                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Uploaddata]").With<MainGrid>().Execute("@QueryType", "@EntityId", "BindRecord", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }



        public Dictionary<string, object> BindOnRowdblClick(string UploadHeaderId)
        {

            try
            {

                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Uploaddata]").With<GridUnsuccess>().With<GridSuccess>().With<MainGridDetails>().Execute("@QueryType", "@UploadHeaderId", "Legacy_RowdbClick", UploadHeaderId));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> UploadExcel(string xml,string UserId, string EntityId,string FileName)
        {

            try
            {

                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Uploaddata]").With<GridUnsuccess>().With<GridSuccess>().With<MainGridDetails>().Execute("@QueryType", "@XmlDimension", "@EntityID", "@UserID", "Legacy_UploadExcel", xml, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                Result.Add("FileName", FileName);
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> btnSave_Click(string EntityId, string UserId, string UploadHeaderId, string TotalCount, string validatedcount, string FileName)
        {

            try
            {

                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Uploaddata]").With<MainGrid>().Execute("@QueryType", "@UploadHeaderId", "@UserID", "@FileName", "@TotalCount", "@SuccessCunt", "@LegacyId", "@EntityId", "Legacy_InsertBulkData", UploadHeaderId, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), FileName, TotalCount, validatedcount, UploadHeaderId, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}