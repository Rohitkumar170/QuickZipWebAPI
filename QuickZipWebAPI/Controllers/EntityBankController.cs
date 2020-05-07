using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models.EntityBankSetup;
using QuickZipWebAPI.Models;
using System.Xml;
using System.Data;
using System.Xml.Linq;

namespace QuickZipWebAPI.Controllers
{
    public class EntityBankController : ApiController
    {
        EntityBank objuser = new EntityBank();

        [HttpGet]
        [Route("api/EntityBank/getEntity")]
        public Dictionary<string, object> getEntity()
        {
           
            return objuser.getEntity();
        }

        [HttpGet]
        [Route("api/EntityBank/getBank/{EntityId}")]
        public Dictionary<string, object> getBank(string EntityId)
        {

            return objuser.getBank(EntityId);
        }

        [HttpGet]
        [Route("api/EntityBank/EditData/{EntityId}/{BankId}")]
        public Dictionary<string, object> EditData(string EntityId, string BankId)
        {

            return objuser.EditData(EntityId, BankId);
        }

        [HttpPost]
        [Route("api/EntityBank/SaveData")]
        public IEnumerable<Adhocdata>SaveData([FromBody] Adhocdata adhocdata)
        {
            int fileformatxml = 0;
            int fileformatexcel = 0;
            int fileformatcsv = 0;
            int FilesendDaily = 0;
            var FilesendWeekly = 0;
            var FilesendMonthly = 0;
            var FilesendSpecific = 0;

            if (adhocdata.chkxml== true)
            {
                fileformatxml = 1;
            }
            else
            {
                fileformatxml = 0;
            }

            if (adhocdata.chkexcel == true)
            {
                fileformatexcel = 1;
            }
            else
            {
                fileformatexcel = 0;
            }

            if (adhocdata.chkcsv == true)
            {
                fileformatcsv = 1;
            }
            else
            {
                fileformatcsv = 0;
            }

            if (adhocdata.rdoDate == "D")
            {
                FilesendDaily = 1;
            }
            else if (adhocdata.rdoDate == "W")
            {
                FilesendWeekly = 1;
            }
            else if (adhocdata.rdoDate == "M")
            {
                FilesendMonthly = 1;
            }
            else if (adhocdata.rdoDate == "A")
            {
                FilesendSpecific = 1;
            }

            string dtDate = "<dtXml>";
            string dtFileSequence = "<dtXml>";
            string date = adhocdata.rdoDate;
            string DailyTime = "";
            string MonthlyDate = "";
            string WeeklyDate = "";
            var PositionCount = 1;


            if (date == "D")
            {
                DailyTime = adhocdata.txtdatepicker;
                if (DailyTime == "")
                {


                }
                // "SponsorBankCodeId=" + @"""" + userdata.sponsorbankcode + @"""";
                else
                {
                    dtDate += "<dtXml ";
                    dtDate += " DailyTime = " + @"""" + DailyTime + @"""";
                    dtDate += " />";
                }
            }

            else if (date == "M")
            {
                if (adhocdata.txtdatepicker2 == "")
                { }
                else if (adhocdata.txtdatepicker4 == "")
                { }
                else
                {

                    MonthlyDate = ((adhocdata.txtdatepicker2) + '_' + (adhocdata.txtdatepicker4));
                    dtDate += "<dtXml ";
                    dtDate += " MonthlyDate = " + @"""" + MonthlyDate + @"""";
                    dtDate += " />";
                }
            }
            else if (date == "W")
            {
                if (adhocdata.ddlday == 0)
                { }
                else if (adhocdata.txtdatepicker1 == "")
                { }
                else
                {
                    WeeklyDate = ((adhocdata.ddlday) + '_' + (adhocdata.txtdatepicker1));
                    dtDate += "<dtXml ";
                    dtDate += " WeeklyDate = " + @"""" + WeeklyDate + @"""";
                    dtDate += " />";
                }
            }

            else if (date == "A")
            {
               

                var AdValue = "";

                    for (var i = 0; i < adhocdata.adhocarr.Count; i++)
                    {

                        AdValue = AdValue + adhocdata.adhocarr[i] + ',';


                    }

                    AdValue = AdValue.TrimEnd(',');
                    dtDate += "<dtXml ";

                    dtDate += " Adhocs = " + @"""" + AdValue + @"""";
                    dtDate += " />";
                

            }
            dtDate += "</dtXml>";

           
            dtFileSequence += "<dtXml ";

            for (var i = 0; i < adhocdata.arrsequence.Count; i++)
            {

                dtFileSequence += " SEQ" + PositionCount + " = " + @"""" + adhocdata.arrsequence[i] + @"""";
                PositionCount++;
            }

            dtFileSequence += " TotalLength=" + @"""" + adhocdata.txttotalcount + @"""";
            dtFileSequence += " EntityId = " + @"""" + adhocdata.ddlentity + @"""";
            dtFileSequence += " />";
            dtFileSequence += "</dtXml>";





            return objuser.SaveData(adhocdata,adhocdata.UserId, fileformatxml, fileformatexcel, fileformatcsv, FilesendDaily, FilesendWeekly, FilesendMonthly, FilesendSpecific, dtDate, dtFileSequence);


        }

        [HttpPost]
        [Route("api/EntityBank/UpdateData/{Id}")]
        public IEnumerable<Adhocdata> UpdateData([FromBody] Adhocdata adhocdata, int Id)
        {
            int fileformatxml = 0;
            int fileformatexcel = 0;
            int fileformatcsv = 0;
            int FilesendDaily = 0;
            var FilesendWeekly = 0;
            var FilesendMonthly = 0;
            var FilesendSpecific = 0;

            if (adhocdata.chkxml == true)
            {
                fileformatxml = 1;
            }
            else
            {
                fileformatxml = 0;
            }

            if (adhocdata.chkexcel == true)
            {
                fileformatexcel = 1;
            }
            else
            {
                fileformatexcel = 0;
            }

            if (adhocdata.chkcsv == true)
            {
                fileformatcsv = 1;
            }
            else
            {
                fileformatcsv = 0;
            }

            if (adhocdata.rdoDate == "D")
            {
                FilesendDaily = 1;
            }
            else if (adhocdata.rdoDate == "W")
            {
                FilesendWeekly = 1;
            }
            else if (adhocdata.rdoDate == "M")
            {
                FilesendMonthly = 1;
            }
            else if (adhocdata.rdoDate == "A")
            {
                FilesendSpecific = 1;
            }

            string dtDate = "<dtXml>";
            string dtFileSequence = "<dtXml>";
            string date = adhocdata.rdoDate;
            string DailyTime = "";
            string MonthlyDate = "";
            string WeeklyDate = "";
            var PositionCount = 1;


            if (date == "D")
            {
                DailyTime = adhocdata.txtdatepicker;
                if (DailyTime == "")
                {


                }
                // "SponsorBankCodeId=" + @"""" + userdata.sponsorbankcode + @"""";
                else
                {
                    dtDate += "<dtXml ";
                    dtDate += " DailyTime = " + @"""" + DailyTime + @"""";
                    dtDate += " />";
                }
            }

            else if (date == "M")
            {
                if (adhocdata.txtdatepicker2 == "")
                { }
                else if (adhocdata.txtdatepicker4 == "")
                { }
                else
                {

                    MonthlyDate = ((adhocdata.txtdatepicker2) + "_" + (adhocdata.txtdatepicker4));
                    dtDate += "<dtXml ";
                    dtDate += " MonthlyDate = " + @"""" + MonthlyDate + @"""";
                    dtDate += " />";
                }
            }
            else if (date == "W")
            {
                if (adhocdata.ddlday == 0)
                { }
                else if (adhocdata.txtdatepicker1 == "")
                { }
                else
                {
                    WeeklyDate = ((adhocdata.ddlday) + "_" + (adhocdata.txtdatepicker1));
                    dtDate += "<dtXml ";
                    dtDate += " WeeklyDate = " + @"""" + WeeklyDate + @"""";
                    dtDate += " />";
                }
            }

            else if (date == "A")
            {

                var AdValue = "";

                for (var i = 0; i < adhocdata.adhocarr.Count; i++)
                {

                    AdValue = AdValue + adhocdata.adhocarr[i] + ',';


                }

                AdValue = AdValue.TrimEnd(',');
                dtDate += "<dtXml ";

                dtDate += " Adhocs = " + @"""" + AdValue + @"""";
                dtDate += " />";

            }
            dtDate += "</dtXml>";

            dtFileSequence += "<dtXml ";

            for (var i = 0; i < adhocdata.arrsequence.Count; i++)
            {

                dtFileSequence += " SEQ" + PositionCount + " = " + @"""" + adhocdata.arrsequence[i] + @"""";
                PositionCount++;
            }

            dtFileSequence += " TotalLength=" + @"""" + adhocdata.txttotalcount + @"""";
            dtFileSequence += " EntityId = " + @"""" + adhocdata.ddlentity + @"""";
            dtFileSequence += " />";
            dtFileSequence += "</dtXml>";




            return objuser.UpdateData(adhocdata, adhocdata.UserId, fileformatxml, fileformatexcel, fileformatcsv, FilesendDaily, FilesendWeekly, FilesendMonthly, FilesendSpecific, dtDate, dtFileSequence, Id);


        }

    }
}
