using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models.User;
using QuickZipWebAPI.Models;
using System.Xml;
using System.Data;
using System.Xml.Linq;

namespace QuickZipWebAPI.Controllers
{
    public class USerController : ApiController
    {
        User objuser = new User();
        [HttpGet]
        [Route("api/USer/getUserData/{EntityId}/{PageCount}/{Search_Text}")]
        public Dictionary<string, object> getUserData(string EntityId, string PageCount, string Search_Text)
        {
            if (Search_Text == "0")
            {
                Search_Text = "";
            }
            return objuser.GetAllUsers(EntityId, PageCount, Search_Text);
        }

        [HttpGet]
        [Route("api/USer/getMakers/{EntityId}/{UserId}")]
        public Dictionary<string, object> getMakers(string EntityId, string UserId)
        {

            return objuser.GetAllMakers(EntityId, UserId);
        }

        [HttpGet]
        [Route("api/USer/getUserReport/{EntityId}")]
        public Dictionary<string, object> getUserReport(string EntityId)
        {

            return objuser.getUserReportData(EntityId);
        }
        [HttpGet]
        [Route("api/USer/CheckIsPresentmentChecker/{EntityId}")]
        public Dictionary<string, object> CheckIsPresentmentChecker(string EntityId)
        {

            return objuser.CheckIsPresentmentChecker(EntityId);
        }

        [HttpGet]
        [Route("api/USer/EditData/{UserId}")]
        public Dictionary<string, object> EditData(string UserId)
        {

            return objuser.EditUserData(UserId);
        }

        [HttpPost]
        [Route("api/USer/SaveData/{EntityId}/{UserId}/{IsViewAll}/{checkbulkuploadlink}/{chkvideolink}")]
        public IEnumerable<Users> SaveData([FromBody] Users userdata, string EntityId, string UserId, int IsViewAll, string checkbulkuploadlink, string chkvideolink)
        {
            string dtPaymentMode = "<dtXml></dtXml>";

            int IsZipSure = 0;
            int IsAllowFundTransfer = 0;
            int IsMandateEdit = 0;
            int Ismandate = 0;
            int IsBulk = 0;
            int iSDashboard = 0;
            int IsEnableCancel = 0;

            string Defaultpwd = "1";
            var dtSponsorBankCode = "<dtXml>";



            dtSponsorBankCode = "<dtXml>";

            //for (var i = 0; i < userdata.sponsorbankcode.Length; i++)
            //{
            dtSponsorBankCode += "<dtXml ";
            dtSponsorBankCode += "SponsorBankCodeId=" + @"""" + userdata.sponsorbankcode + @"""";
            dtSponsorBankCode += " />";
            // }
            dtSponsorBankCode += "</dtXml>";

            var dtCategoryCode = "<dtXml>";

            dtCategoryCode = "<dtXml>";


            dtCategoryCode += "<dtXml ";
            dtCategoryCode += "CategoryCode=" + @"""" + userdata.categorycode + @"""";
            dtCategoryCode += " />";

            dtCategoryCode += "</dtXml>";



            var dtPresentmentMaker = "<dtXml>";
            // for (var i = 0; i < userdata.maker.Length; i++)
            //{
            dtPresentmentMaker += "<dtXml ";
            dtPresentmentMaker += "PresentmentMakerId=" + @"""" + userdata.maker + @"""";
            dtPresentmentMaker += " />";
            // }
            dtPresentmentMaker += "</dtXml>";

            var dtUserRights_1 = "<dtXml>";
            dtUserRights_1 += "<dtXml";

            if (userdata.chkDownload == true)
            {
                dtUserRights_1 += " rdoNachMandate_Download = " + @"""" + 1 + @"""";
            }
            else
            {
                dtUserRights_1 += " rdoNachMandate_Download = " + @"""" + 0 + @"""";
            }
            if (userdata.chkCreate == true)
            {
                dtUserRights_1 += " NachMandate_Create = " + @"""" + 1 + @"""";
            }
            else
            {
                dtUserRights_1 += " NachMandate_Create = " + @"""" + 0 + @"""";
            }

            if (userdata.chkView == true)
            {
                dtUserRights_1 += " NachMandate_View = " + @"""" + 1 + @"""";
            }
            else
            {
                dtUserRights_1 += "  NachMandate_View = " + @"""" + 0 + @"""";
            }
            dtUserRights_1 += " /></dtXml>";



            var dtUserRights_2 = "<dtXml>";
            if (userdata.chkUmrnHistory == true)
            {
                dtUserRights_2 += "<dtXml ";
                dtUserRights_2 += " LinkIDs = " + @"""" + 17 + @"""";
                dtUserRights_2 += " />";
            }

            if (userdata.chkUmrnUpload == true)
            {
                dtUserRights_2 += "<dtXml";
                dtUserRights_2 += " LinkIDs = " + @"""" + 18 + @"""";
                dtUserRights_2 += " />";
            }

            if (userdata.chkAllUMRN == true)
            {
                dtUserRights_2 += "<dtXml";
                dtUserRights_2 += " LinkIDs = " + @"""" + 22 + @"""";
                dtUserRights_2 += " />";
            }

            if (userdata.chknachpresentment == true)
            {
                dtUserRights_2 += "<dtXml";
                dtUserRights_2 += " LinkIDs = " + @"""" + 19 + @"""";
                dtUserRights_2 += " />";
            }
            dtUserRights_2 += "</dtXml>";
            int chkPresentMaker = 0;
            int chkPresentChecker = 0;
            int chkRefEdit = 0;

            if (userdata.chkPresentMaker == true)
            {
                chkPresentMaker = 1;
            }
            else
            {
                chkPresentMaker = 0;
            }
            if (userdata.chkPresentChecker == true)
            {
                chkPresentChecker = 1;
            }
            else
            {
                chkPresentMaker = 0;
            }
            if (userdata.chkRefEdit == true)
            {
                chkRefEdit = 1;
            }
            else
            {
                chkRefEdit = 0;
            }

            if (userdata.chkEnableCancel == true)
            {
                IsEnableCancel = 1;
            }
            else
            {
                IsEnableCancel = 0;
            }

            if (userdata.nachuser == null)
            {
                userdata.nachuser = "";
            }
            if (userdata.maker == null)
            {
                userdata.maker = "";
            }

            string[] checkbulkuploadlnk = checkbulkuploadlink.Split(',');
            string[] chkvideolnk = chkvideolink.Split(',');



            XDocument doc = new XDocument();
            doc.Add(new XElement("dtXml", checkbulkuploadlnk.Select(x => new XElement("LinkIDs", x))));

            XDocument doc1 = new XDocument();
            doc1.Add(new XElement("dtXml", chkvideolnk.Select(x => new XElement("LinkIDs", x))));


            DataTable dt = new DataTable();
            dt.Columns.Add("LinkIDs", typeof(Int64));
            // Boolean IsFound = false;

            for (int i = 0; i < checkbulkuploadlnk.Length; i++)
            {
                DataRow dr = dt.NewRow();

                // dr = IsMandateID;
                dt.Rows.Add(checkbulkuploadlnk[i]);


            }
            string dtUserRights_3 = GetXmlByDatable(dt);

            DataTable dt1 = new DataTable();
            dt1.Columns.Add("LinkIDs", typeof(Int64));

            for (int i = 0; i < chkvideolnk.Length; i++)
            {
                DataRow dr = dt.NewRow();

                // dr = IsMandateID;
                dt1.Rows.Add(chkvideolnk[i]);


            }
            string dtUserRights_4 = GetXmlByDatable(dt1);


            //dtUserRights_3 = "<dtXml>";

            ////for (var i = 0; i < userdata.sponsorbankcode.Length; i++)
            ////{
            //dtUserRights_3 += "<dtXml ";
            //dtUserRights_3 += "LinkIDs=" + @"""" + userdata.chkbulkuploadlink + @"""";
            //dtUserRights_3 += " />";
            //// }
            //dtUserRights_3 += "</dtXml>";



            //for (var i = 0; i < userdata.sponsorbankcode.Length; i++)
            //{
            //dtUserRights_4 = "<dtXml>";
            //dtUserRights_4 += "<dtXml ";
            //dtUserRights_4 += "LinkIDs=" + @"""" + userdata.chkvideolink + @"""";
            //dtUserRights_4 += " />";
            //// }
            //dtUserRights_4 += "</dtXml>";

            return objuser.SaveUserData(userdata, EntityId, UserId, dtUserRights_1, dtUserRights_2, dtSponsorBankCode, dtCategoryCode, dtPresentmentMaker, chkPresentMaker, chkPresentChecker, IsZipSure, IsAllowFundTransfer, IsMandateEdit, Ismandate, IsBulk, iSDashboard, IsEnableCancel, IsViewAll, Defaultpwd, dtPaymentMode, dtUserRights_3, dtUserRights_4, chkRefEdit);
        }

        [HttpPost]
        [Route("api/USer/UpdateData/{EntityId}/{UserId}/{Id}/{IsViewAll}/{checkbulkuploadlink}/{chkvideolink}")]
        public IEnumerable<Users> UpdateData([FromBody] Users userdata, string EntityId, string UserId, int Id, int IsViewAll, string checkbulkuploadlink, string chkvideolink)
        {
            string dtPaymentMode = "<dtXml></dtXml>";

            int IsZipSure = 0;
            int IsAllowFundTransfer = 0;
            int IsMandateEdit = 0;
            int Ismandate = 0;
            int IsBulk = 0;
            int iSDashboard = 0;
            int IsEnableCancel = 0;

            string Defaultpwd = "1";
            var dtSponsorBankCode = "<dtXml>";



            dtSponsorBankCode = "<dtXml>";

            //for (var i = 0; i < userdata.sponsorbankcode.Length; i++)
            //{
            dtSponsorBankCode += "<dtXml ";
            dtSponsorBankCode += "SponsorBankCodeId=" + @"""" + userdata.sponsorbankcode + @"""";
            dtSponsorBankCode += " />";
            // }
            dtSponsorBankCode += "</dtXml>";

            var dtCategoryCode = "<dtXml>";

            dtCategoryCode = "<dtXml>";


            dtCategoryCode += "<dtXml ";
            dtCategoryCode += "CategoryCode=" + @"""" + userdata.categorycode + @"""";
            dtCategoryCode += " />";

            dtCategoryCode += "</dtXml>";



            var dtPresentmentMaker = "<dtXml>";
            // for (var i = 0; i < userdata.maker.Length; i++)
            //{
            dtPresentmentMaker += "<dtXml ";
            dtPresentmentMaker += "PresentmentMakerId=" + @"""" + userdata.maker + @"""";
            dtPresentmentMaker += " />";
            // }
            dtPresentmentMaker += "</dtXml>";

            var dtUserRights_1 = "<dtXml>";
            dtUserRights_1 += "<dtXml";

            if (userdata.chkDownload == true)
            {
                dtUserRights_1 += " rdoNachMandate_Download = " + @"""" + 1 + @"""";
            }
            else
            {
                dtUserRights_1 += " rdoNachMandate_Download = " + @"""" + 0 + @"""";
            }
            if (userdata.chkCreate == true)
            {
                dtUserRights_1 += " NachMandate_Create = " + @"""" + 1 + @"""";
            }
            else
            {
                dtUserRights_1 += " NachMandate_Create = " + @"""" + 0 + @"""";
            }

            if (userdata.chkView == true)
            {
                dtUserRights_1 += " NachMandate_View = " + @"""" + 1 + @"""";
            }
            else
            {
                dtUserRights_1 += "  NachMandate_View = " + @"""" + 0 + @"""";
            }
            dtUserRights_1 += " /></dtXml>";



            var dtUserRights_2 = "<dtXml>";
            if (userdata.chkUmrnHistory == true)
            {
                dtUserRights_2 += "<dtXml ";
                dtUserRights_2 += " LinkIDs = " + @"""" + 17 + @"""";
                dtUserRights_2 += " />";
            }

            if (userdata.chkUmrnUpload == true)
            {
                dtUserRights_2 += "<dtXml";
                dtUserRights_2 += " LinkIDs = " + @"""" + 18 + @"""";
                dtUserRights_2 += " />";
            }

            if (userdata.chkAllUMRN == true)
            {
                dtUserRights_2 += "<dtXml";
                dtUserRights_2 += " LinkIDs = " + @"""" + 22 + @"""";
                dtUserRights_2 += " />";
            }

            if (userdata.chknachpresentment == true)
            {
                dtUserRights_2 += "<dtXml";
                dtUserRights_2 += " LinkIDs = " + @"""" + 19 + @"""";
                dtUserRights_2 += " />";
            }
            dtUserRights_2 += "</dtXml>";
            int chkPresentMaker = 0;
            int chkPresentChecker = 0;
            int chkRefEdit = 0;

            if (userdata.chkPresentMaker == true)
            {
                chkPresentMaker = 1;
            }
            else
            {
                chkPresentMaker = 0;
            }
            if (userdata.chkPresentChecker == true)
            {
                chkPresentChecker = 1;
            }
            else
            {
                chkPresentMaker = 0;
            }
            if (userdata.chkRefEdit == true)
            {
                chkRefEdit = 1;
            }
            else
            {
                chkRefEdit = 0;
            }

            if (userdata.chkEnableCancel == true)
            {
                IsEnableCancel = 1;
            }
            else
            {
                IsEnableCancel = 0;
            }

            if (userdata.nachuser == null)
            {
                userdata.nachuser = "";
            }
            if (userdata.maker == null)
            {
                userdata.maker = "";
            }



            string[] checkbulkuploadlnk = checkbulkuploadlink.Split(',');
            string[] chkvideolnk = chkvideolink.Split(',');



            XDocument doc = new XDocument();
            doc.Add(new XElement("dtXml", checkbulkuploadlnk.Select(x => new XElement("LinkIDs", x))));

            XDocument doc1 = new XDocument();
            doc1.Add(new XElement("dtXml", chkvideolnk.Select(x => new XElement("LinkIDs", x))));


            DataTable dt = new DataTable();
            dt.Columns.Add("LinkIDs", typeof(Int64));
            // Boolean IsFound = false;

            for (int i = 0; i < checkbulkuploadlnk.Length; i++)
            {
                DataRow dr = dt.NewRow();

                // dr = IsMandateID;
                dt.Rows.Add(checkbulkuploadlnk[i]);


            }
            string dtUserRights_3 = GetXmlByDatable(dt);

            DataTable dt1 = new DataTable();
            dt1.Columns.Add("LinkIDs", typeof(Int64));

            for (int i = 0; i < chkvideolnk.Length; i++)
            {
                DataRow dr = dt.NewRow();

                // dr = IsMandateID;
                dt1.Rows.Add(chkvideolnk[i]);


            }
            string dtUserRights_4 = GetXmlByDatable(dt1);










            //dtUserRights_3 = "<dtXml>";


            //dtUserRights_3 += "<dtXml ";
            //dtUserRights_3 += "LinkIDs=" + @"""" + userdata.chkbulkuploadlink + @"""";
            //dtUserRights_3 += " />";

            //dtUserRights_3 += "</dtXml>";

            //dtUserRights_4 = "<dtXml>";


            //dtUserRights_4 += "<dtXml ";
            //dtUserRights_4 += "LinkIDs=" + @"""" + userdata.chkvideolink + @"""";
            //dtUserRights_4 += " />";

            //dtUserRights_4 += "</dtXml>";

            return objuser.UpdateUserData(userdata, EntityId, UserId, dtUserRights_1, dtUserRights_2, dtSponsorBankCode, dtCategoryCode, dtPresentmentMaker, chkPresentMaker, chkPresentChecker, IsZipSure, IsAllowFundTransfer, IsMandateEdit, Ismandate, IsBulk, iSDashboard, IsEnableCancel, IsViewAll, Defaultpwd, dtPaymentMode, dtUserRights_3, dtUserRights_4, chkRefEdit, Id);
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
