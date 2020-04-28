using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using BusinessLibrary;
using QuickZipWebAPI.Entity;
using QuickZipWebAPI.Models;

namespace QuickZipWebAPI.Models.OldMandate
{
    public class OldMandateClass
    {
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        List<OldMandateAttribute> dataList = new List<OldMandateAttribute>();
        List< downloadOldMandateTableAttibute> downlodmanlist = new List<downloadOldMandateTableAttibute>();

        public IEnumerable<OldMandateAttribute> GetUserBankData(string UserId)
        {
            try
            {

                var Data = dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<OldMandateAttribute>().Execute("@QueryType", "@UserId", "UserBank", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))));
                foreach(var dt in Data)
                {
                    dataList = dt.Cast<OldMandateAttribute>().ToList();
                }
                return dataList;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        //search by Reference

        public IEnumerable<OldMandateAttribute> GetAllDataByRefrence(string UserId,string Refrence1)
        {
            try
            {
                var Data = dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<OldMandateAttribute>().Execute("@QueryType", "@UserId", "@Refrence1", "grdOldMandateRefrenceise", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), Refrence1);
                foreach (var dt in Data)
                {
                    dataList = dt.Cast<OldMandateAttribute>().ToList();
                }
                return dataList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<OldMandateAttribute> GetAllDataByDate(string UserId, string strFromDate,string strToDate,string SponsorBankCode)
        {
            try
            {
                var Data = dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<OldMandateAttribute>().Execute("@QueryType", "@UserId", "@strFromDate", "@strToDate", "@SponsorBankCode", "grdOldMandateDateWise", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), strFromDate, strToDate, SponsorBankCode);
                foreach (var dt in Data)
                {
                    dataList = dt.Cast<OldMandateAttribute>().ToList();
                }
                return dataList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<OldMandateAttribute> RejectData(string strFromDate, string strToDate, string RejectedReason, string UserId, string strTable)
        {
            string[] mandatearr = strTable.Split(',');

            //int[] values = { 1, 2, 17, 8 };

            XDocument doc = new XDocument();
            doc.Add(new XElement("dtXml", mandatearr.Select(x => new XElement("MandateId", x))));










            DataTable dt = new DataTable();
            dt.Columns.Add("MandateId", typeof(Int64));
            // Boolean IsFound = false;

            for (int i = 0; i < mandatearr.Length; i++)
            {
                DataRow dr = dt.NewRow();

                // dr = IsMandateID;
                dt.Rows.Add(mandatearr[i]);

                // dt.Rows.Add(dr);
                //IsFound = true;
                // }
                //}



            }
            string strTable1 = GetXmlByDatable(dt);


            try
            {
                var Data = dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<OldMandateAttribute>().Execute("@QueryType", "@strTable", "@strFromDate", "@strToDate", "@UserId", "@RejectedReason", "RejectdataDateWise", strTable1, strFromDate, strToDate, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), RejectedReason );
                foreach (var dt1 in Data)
                {
                    dataList = dt1.Cast<OldMandateAttribute>().ToList();
                }
                return dataList;
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