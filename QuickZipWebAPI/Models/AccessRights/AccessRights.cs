using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickZipWebAPI.Entity;
using BusinessLibrary;
using System.Xml;
using System.Data;
using System.Xml.Linq;
using System.Web.UI.WebControls;

namespace QuickZipWebAPI.Models.AccessRights
{
    public class AccessRights
    {

        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        List<CommonFlag> common = new List<CommonFlag>();
        CommonFlag Flag = new CommonFlag();
        List<AccessRightsEntityDetails> dataList = new List<AccessRightsEntityDetails>();

        List<AccessRightDetails> dataList1 = new List<AccessRightDetails>();

        public IEnumerable<AccessRightsEntityDetails> BindEntityDetails(string UserType, string ReferenceId)
        {
            // List<DownloadMandateDetails> dataList = new List<DownloadMandateDetails>();
            try
            {
                var Result = dbcontext.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<AccessRightsEntityDetails>().Execute("@QueryType", "@userType", "@EntityID", "GetUsersType", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserType.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(ReferenceId.Replace("_", "%"))));

                foreach (var employe in Result)
                {
                    dataList = employe.Cast<AccessRightsEntityDetails>().ToList();
                }
                return dataList;

                // return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public IEnumerable<AccessRightDetails> BindAccessRightDetails(string userid, string UserType)
        {
            // List<DownloadMandateDetails> dataList = new List<DownloadMandateDetails>();
            try
            {
                var Result = dbcontext.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<AccessRightDetails>().Execute("@QueryType", "@UserID", "@UserType", "GetLinksForUser", userid, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserType.Replace("_", "%"))));

                foreach (var employee in Result)
                {
                    dataList1 = employee.Cast<AccessRightDetails>().ToList();
                }
                return dataList1;

                // return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public Dictionary<string, object> Insertdata(string userid, string storeIsActive, string storeIsRead, string storeLinkID, string CUserId)
        {
            string[] active = storeIsActive.Split(',');
            string[] read = storeIsRead.Split(',');
            string[] linkid = storeLinkID.Split(',');



            XDocument doc = new XDocument();
            XDocument doc1 = new XDocument();
            XDocument doc2 = new XDocument();
            doc.Add(new XElement("dtXml", active.Select(x => new XElement("IsActive", x))));
            doc1.Add(new XElement("dtXml", read.Select(x => new XElement("IsRead", x))));
            doc2.Add(new XElement("dtXml", linkid.Select(x => new XElement("LinkID", x))));


            DataTable dt = new DataTable();
            dt.Columns.Add("IsActive", typeof(bool));


            // Boolean IsFound = false;

            for (int i = 0; i < active.Length; i++)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(active[i]);

            }

            dt.Columns.Add("IsRead", typeof(bool));
            for (int i = 0; i < read.Length; i++)
            {
                //for (int j = 0; j < read.Length; j++) {
                DataRow dr = dt.NewRow();
                //dt.Rows.Add(read[i]);
                dt.Rows[i]["IsRead"] = read[i];
                //    dt.Rows[0].SetAdded(read[i]);
                //}
            }

            dt.Columns.Add("LinkID", typeof(Int64));
            for (int i = 0; i < linkid.Length; i++)
            {
                DataRow dr = dt.NewRow();
                // dt.Rows.Add(linkid[i]);
                dt.Rows[i]["LinkID"] = linkid[i];

            }

            string dtAccessRights = GetXmlByDatable(dt);


            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<AccessRightDetails>().Execute("@QueryType", "@UserID", "@AccessRightsXml", "@Createdby", "InsertAccessRightsData", userid, dtAccessRights, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(CUserId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetXmlByDatable(DataTable dtObjectforXml)
        {
            if (dtObjectforXml == null)
                return "";
            if (dtObjectforXml.Rows.Count == 0)
                return "";

            if (dtObjectforXml.TableName == "")
                dtObjectforXml.TableName = "dtXml";

            XmlDocument objectXmlDocument = new XmlDocument();
            XmlElement objElement = objectXmlDocument.CreateElement(dtObjectforXml.TableName);

            for (int iRecordCounter = 0; iRecordCounter < dtObjectforXml.Rows.Count; iRecordCounter++)
            {
                // Generate XmlObject and Append Nodes by calling a Child function.
                objElement.AppendChild(BuildXmlElement(dtObjectforXml.Rows[iRecordCounter], objectXmlDocument));
            }

            objectXmlDocument.AppendChild(objElement);
            return objectXmlDocument.OuterXml;
        }

        private XmlElement BuildXmlElement(DataRow drObjectforXml, XmlDocument objectXmlDocument)
        {
            XmlElement XmlElement = objectXmlDocument.CreateElement(drObjectforXml.Table.TableName);
            for (int iColumnCounter = 0; iColumnCounter < drObjectforXml.Table.Columns.Count; iColumnCounter++)
            {
                XmlElement.SetAttribute(drObjectforXml.Table.Columns[iColumnCounter].ColumnName, Convert.ToString(drObjectforXml[iColumnCounter].ToString()));
            }

            return XmlElement;
        }

    }
}