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
        [Route("api/EntityBank/SaveData/{UserId}/{arrvalue}/{adhocarr}")]
        public IEnumerable<EntityData> SaveData([FromBody] EntityData entity, string UserId, string arrvalue, string adhocarr)
        {
            int fileformatxml = 0;
            int fileformatexcel = 0;
            int fileformatcsv = 0;
            int FilesendDaily = 0;
            var FilesendWeekly = 0;
            var FilesendMonthly = 0;
            var FilesendSpecific = 0;

            if (entity.chkxml == true)
            {
                fileformatxml = 1;
            }
            else
            {
                fileformatxml = 0;
            }

            if (entity.chkexcel == true)
            {
                fileformatexcel = 1;
            }
            else
            {
                fileformatexcel = 0;
            }

            if (entity.chkcsv == true)
            {
                fileformatcsv = 1;
            }
            else
            {
                fileformatcsv = 0;
            }

            if (entity.rdoDate == "D")
            {
                FilesendDaily = 1;
            }
            else if (entity.rdoDate == "W")
            {
                FilesendWeekly = 1;
            }
            else if (entity.rdoDate == "M")
            {
                FilesendMonthly = 1;
            }
            else if (entity.rdoDate == "A")
            {
                FilesendSpecific = 1;
            }

            string dtDate = "<dtXml>";
            string dtFileSequence = "<dtXml>";
            string date = entity.rdoDate;
            string DailyTime = "";
            string MonthlyDate = "";
            string WeeklyDate = "";
            var PositionCount = 1;


            if (date == "D")
            {
                DailyTime = entity.txtdatepicker;
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
                if (entity.txtdatepicker2 == "")
                { }
                else if (entity.txtdatepicker4 == "")
                { }
                else
                {

                    MonthlyDate = ((entity.txtdatepicker2) + '_' + (entity.txtdatepicker4));
                    dtDate += "<dtXml ";
                    dtDate += " MonthlyDate = " + @"""" + MonthlyDate + @"""";
                    dtDate += " />";
                }
            }
            else if (date == "W")
            {
                if (entity.ddlday == 0)
                { }
                else if (entity.txtdatepicker1 == "")
                { }
                else
                {
                    WeeklyDate = ((entity.ddlday) + '_' + (entity.txtdatepicker1));
                    dtDate += "<dtXml ";
                    dtDate += " WeeklyDate = " + @"""" + WeeklyDate + @"""";
                    dtDate += " />";
                }
            }

            else if (date == "A")
            {
                if (adhocarr != "" || adhocarr != "0")
                {
                    string[] adhocarr1 = adhocarr.Split(',');
                    var AdValue = "";

                    for (var i = 0; i < adhocarr1.Length; i++)
                    {



                        AdValue = AdValue + adhocarr1[i] + ',';


                    }

                    AdValue = AdValue.TrimEnd(',');
                    dtDate += "<dtXml ";

                    dtDate += " Adhocs = " + @"""" + AdValue + @"""";
                    dtDate += " />";
                }

            }
            dtDate += "</dtXml>";

            string[] arrvalue1 = arrvalue.Split(',');

            dtFileSequence += "<dtXml ";

            for (var i = 0; i < arrvalue1.Length; i++)
            {

                dtFileSequence += " SEQ" + PositionCount + " = " + @"""" + arrvalue1[i] + @"""";
                PositionCount++;
            }

            dtFileSequence += " TotalLength=" + @"""" + entity.txttotalcount + @"""";
            dtFileSequence += " EntityId = " + @"""" + entity.ddlentity + @"""";
            dtFileSequence += " />";
            dtFileSequence += "</dtXml>";





            return objuser.SaveData(entity, UserId, fileformatxml, fileformatexcel, fileformatcsv, FilesendDaily, FilesendWeekly, FilesendMonthly, FilesendSpecific, dtDate, dtFileSequence);


        }

        [HttpPost]
        [Route("api/EntityBank/UpdateData/{UserId}/{arrvalue}/{adhocarr}/{Id}")]
        public IEnumerable<EntityData> UpdateData([FromBody] EntityData entity, string UserId, string arrvalue, string adhocarr, int Id)
        {
            int fileformatxml = 0;
            int fileformatexcel = 0;
            int fileformatcsv = 0;
            int FilesendDaily = 0;
            var FilesendWeekly = 0;
            var FilesendMonthly = 0;
            var FilesendSpecific = 0;

            if (entity.chkxml == true)
            {
                fileformatxml = 1;
            }
            else
            {
                fileformatxml = 0;
            }

            if (entity.chkexcel == true)
            {
                fileformatexcel = 1;
            }
            else
            {
                fileformatexcel = 0;
            }

            if (entity.chkcsv == true)
            {
                fileformatcsv = 1;
            }
            else
            {
                fileformatcsv = 0;
            }

            if (entity.rdoDate == "D")
            {
                FilesendDaily = 1;
            }
            else if (entity.rdoDate == "W")
            {
                FilesendWeekly = 1;
            }
            else if (entity.rdoDate == "M")
            {
                FilesendMonthly = 1;
            }
            else if (entity.rdoDate == "A")
            {
                FilesendSpecific = 1;
            }

            string dtDate = "<dtXml>";
            string dtFileSequence = "<dtXml>";
            string date = entity.rdoDate;
            string DailyTime = "";
            string MonthlyDate = "";
            string WeeklyDate = "";
            var PositionCount = 1;


            if (date == "D")
            {
                DailyTime = entity.txtdatepicker;
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
                if (entity.txtdatepicker2 == "")
                { }
                else if (entity.txtdatepicker4 == "")
                { }
                else
                {

                    MonthlyDate = ((entity.txtdatepicker2) + "_" + (entity.txtdatepicker4));
                    dtDate += "<dtXml ";
                    dtDate += " MonthlyDate = " + @"""" + MonthlyDate + @"""";
                    dtDate += " />";
                }
            }
            else if (date == "W")
            {
                if (entity.ddlday == 0)
                { }
                else if (entity.txtdatepicker1 == "")
                { }
                else
                {
                    WeeklyDate = ((entity.ddlday) + "_" + (entity.txtdatepicker1));
                    dtDate += "<dtXml ";
                    dtDate += " WeeklyDate = " + @"""" + WeeklyDate + @"""";
                    dtDate += " />";
                }
            }

            else if (date == "A")
            {
                if (adhocarr != "" || adhocarr != "0")
                {
                    string[] adhocarr1 = adhocarr.Split(',');
                    var AdValue = "";

                    for (var i = 0; i < adhocarr1.Length; i++)
                    {



                        AdValue = AdValue + adhocarr1[i] + ',';


                    }

                    AdValue = AdValue.TrimEnd(',');
                    dtDate += "<dtXml ";

                    dtDate += " Adhocs = " + @"""" + AdValue + @"""";
                    dtDate += " />";

                }

            }
            dtDate += "</dtXml>";

            string[] arrvalue1 = arrvalue.Split(',');

            dtFileSequence += "<dtXml ";

            for (var i = 0; i < arrvalue1.Length; i++)
            {

                dtFileSequence += " SEQ" + PositionCount + " = " + @"""" + arrvalue1[i] + @"""";
                PositionCount++;
            }

            dtFileSequence += " TotalLength=" + @"""" + entity.txttotalcount + @"""";
            dtFileSequence += " EntityId = " + @"""" + entity.ddlentity + @"""";
            dtFileSequence += " />";
            dtFileSequence += "</dtXml>";





            return objuser.UpdateData(entity, UserId, fileformatxml, fileformatexcel, fileformatcsv, FilesendDaily, FilesendWeekly, FilesendMonthly, FilesendSpecific, dtDate, dtFileSequence, Id);


        }

    }
}
