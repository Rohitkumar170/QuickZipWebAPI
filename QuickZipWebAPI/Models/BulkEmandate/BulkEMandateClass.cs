using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Xml;
using System.Xml.Linq;
using BusinessLibrary;
using QuickZipWebAPI.Entity;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Net.NetworkInformation;
using QuickZipWebAPI.Models;
using QuickZipWebAPI.Models.BulkEmandate;


namespace QuickZipWebAPI.Models.BulkEmandate
{
    public class BulkEMandateClass
    {
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        List<BulkEmandateAttribute> dataList = new List<BulkEmandateAttribute>();
        List<BulkEmandateTabledatacount> tblcount = new List<BulkEmandateTabledatacount>();

        public Dictionary<string, object> GetData(string UserId,string EntityId,string topVal,string ActivityType)
        {
            try
            {
                var Data = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<BulkEmandateAttribute>().With<BulkEmandateTabledatacount>().Execute("@QueryType", "@UserId", "@EntityId", "@topVal", "@ActivityType", "DataActivity", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), topVal, ActivityType));
                //foreach (var dt in Data)
                //{
                //    dataList= dt.Cast<BulkEmandateAttribute>().ToList();
                //}
                return Data;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}