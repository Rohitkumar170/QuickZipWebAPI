using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickZipWebAPI.Entity;
using QuickZipWebAPI.Models.DownloadMandate;
using BusinessLibrary;
using System.Xml;
using System.Data;
using System.Xml.Linq;
using System.Web.UI.WebControls;

namespace QuickZipWebAPI.Models.DownloadMandate
{
    public class DownloadMandate
    {
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        List<CommonFlag> common = new List<CommonFlag>();
        CommonFlag Flag = new CommonFlag();
        List<DownloadMandateDetails> dataList = new List<DownloadMandateDetails>();
        List<DownloadMandateGridDetails> dataListG = new List<DownloadMandateGridDetails>();
        public IEnumerable<DownloadMandateDetails> Binddropdownbank(string userId)
        {
           // List<DownloadMandateDetails> dataList = new List<DownloadMandateDetails>();
            try
            {
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<DownloadMandateDetails>().Execute("@QueryType", "@UserId", "UserBank", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(userId.Replace("_", "%"))));

                foreach (var employe in Result)
                {
                    dataList = employe.Cast<DownloadMandateDetails>().ToList();
                }
                return dataList;

               // return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public IEnumerable<DownloadMandateGridDetails> BindGrid(string userId, string todate, string fromdate, string sponsorbankcode)
        {
            try
            {
                // var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<DownloadMandateDetails>().Execute("@QueryType", "@UserId", "@strToDate", "@strFromDate", "@SponsorBankCode", "grdMandateRefrenceWise", userId, todate, fromdate, sponsorbankcode));
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<DownloadMandateGridDetails>().Execute("@QueryType", "@UserId", "@strToDate", "@strFromDate", "@SponsorBankCode", "grdMandateDateWise", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(userId.Replace("_", "%"))), todate, fromdate, sponsorbankcode);

                foreach (var bgrid in Result)
                {
                    dataListG = bgrid.Cast<DownloadMandateGridDetails>().ToList();

                }
                return dataListG;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        



        public IEnumerable<DownloadMandateGridDetails> BindGridRef(string userId,string refNo)
        {
            try
            {
                // var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<DownloadMandateDetails>().Execute("@QueryType", "@UserId", "@strToDate", "@strFromDate", "@SponsorBankCode", "grdMandateRefrenceWise", userId, todate, fromdate, sponsorbankcode));
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<DownloadMandateGridDetails>().Execute("@QueryType", "@UserId", "@Refrence1", "grdMandateRefrenceWise", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(userId.Replace("_", "%"))), refNo);

                foreach (var bgrid in Result)
                {
                    dataListG = bgrid.Cast<DownloadMandateGridDetails>().ToList();

                }
                return dataListG;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       // RejectMandate(fromdate, todate, IsMandateID, rejectcomnt);

        //public IEnumerable<DownloadMandateGridDetails> RejectMandate(string userID,string fromdate, string todate, string IsMandateID, string rejectcomnt)
        //{
        //    try
        //    {
        //        // var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<DownloadMandateDetails>().Execute("@QueryType", "@UserId", "@strToDate", "@strFromDate", "@SponsorBankCode", todate fromdate   "grdMandateRefrenceWise",      userId, todate, fromdate, sponsorbankcode));
        //        var Result = dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<DownloadMandateGridDetails>().Execute("@QueryType","@UserId", "@strToDate", "@strFromDate", "@strTable", "@RejectedReason", "RejectdataDateWise", userID, todate, fromdate, IsMandateID, rejectcomnt);

        //        foreach (var bgrid in Result)
        //        {
        //            dataListG = bgrid.Cast<DownloadMandateGridDetails>().ToList();

        //        }
        //        return dataListG;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public Dictionary<string, object> RejectMandate(string userID, string fromdate, string todate, string IsMandateID, string rejectcomnt)
        {
            //string mandateid = "<dtXml><dtXml MandateId='" + IsMandateID + "'/><dtXml>";
            //using (XmlWriter writer = XmlWriter.Create("books.xml"))
            //{
            //    writer.WriteStartElement("book");
            //    writer.WriteElementString("title", "Graphics Programming using GDI+");
            //    writer.WriteElementString("author", "Mahesh Chand");
            //    writer.WriteElementString("publisher", "Addison-Wesley");
            //    writer.WriteElementString("price", "64.95");
            //    writer.WriteEndElement();
            //    writer.Flush();
            //}
            string[] mandatearr = IsMandateID.Split(',');

            

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
            string strTable = GetXmlByDatable(dt);

            try
                {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<DownloadMandateGridDetails>().Execute("@QueryType", "@UserId", "@strToDate", "@strFromDate", "@strTable", "@RejectedReason", "RejectdataDateWise", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(userID.Replace("_", "%"))), todate, fromdate, strTable, rejectcomnt));
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