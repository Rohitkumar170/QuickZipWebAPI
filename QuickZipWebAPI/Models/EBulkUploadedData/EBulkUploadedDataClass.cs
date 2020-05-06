using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Xml;
using System.Xml.Linq;
using BusinessLibrary;
using QuickZipWebAPI.Entity;
using QuickZipWebAPI.Models.EBulkUploadedData;

namespace QuickZipWebAPI.Models.EBulkUploadedData
{
    public class EBulkUploadedDataClass
    {
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        //   List<OldMandateAttribute> dataList = new List<OldMandateAttribute>();
        //  List<downloadOldMandateTableAttibute> downlodmanlist = new List<downloadOldMandateTableAttibute>();
        public Dictionary<string, object> GetData(string ActivityID, string UserId, string EntityId, string TEUHID, string LoadData)
        {
            try
            {

                var Data = Common.Getdata(dbcontext.MultipleResults("Sp_Bulkmandate").With<MainGridAttribute>().With<MainGridTableCountAttribute>().With<InvalidDataAttribute>().With<InvalidGridTableCountAttribute>().With<ValidatedDataAttribute>().With<ValidatedDataTableCountAttribute>().With<AccountRelatedIssueAttribute>().With<AccountRelatedIssueTableCount>().With<MisMatchAttribute>().With<MisMatchTableCount>().With<ValidatedDataAttribute>().With<ValidatedDataTableCountAttribute>().Execute("@QueryType", "@ActivityId", "@UserId", "@EntityId", "@TEUHID", "@topVal", "ActivityWiseViewData", ActivityID,DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), TEUHID, LoadData));
                //foreach (var dt in Data)
                //{
                //    dataList= dt.Cast<BulkEmandateAttribute>().ToList();
                //}
                return Data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}