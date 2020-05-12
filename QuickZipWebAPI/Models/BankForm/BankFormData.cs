using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using BusinessLibrary;
using QuickZipWebAPI.Entity;
using System.Threading.Tasks;
namespace QuickZipWebAPI.Models.BankForm
{
    public class BankFormData
    {
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        List<CheckReference> dataList1 = new List<CheckReference>();
        public Dictionary<string, object> GetPageLoaddata(string UserId,string EntityId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<BindEntityDetails> ().With<BindLogoImageDetails>().With<BindBankNameDetails>().With<BindSponserCode>().With<BindBankUtilityCode>().With<BindBankPaymentMode>().With<BindEntityDetailsdata>().With<BindDebitType>().With<Bindfrequency>().With<BindEntityPeriods>().With<BindEntitydebitcredit>().With<BindEntityCategorytype>().With<BindLogincheck>().Execute("@QueryType", "@UserId", "@EntityId", "UserData", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> CheckReference(CheckReference checkreference, string mandateId, string EntityId)
        {
            try
            {
                if(mandateId=="0")
                {
                    mandateId = "";
                }
                else
                {

                }
               
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<CheckReference>().With<CheckReference>().Execute("@QueryType", "@mandateId", "@Refrence1", "@EntityId", "CheckRefrence", mandateId, checkreference.Refrence1, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
               // Result.Add("IsRefrenceCheck", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(IsRefrenceCheck.Replace("_", "%"))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Dictionary<string, object> SaveData(SaveData savedata, string UserId, string EntityId,string mandateid)
        {
            var Result = new Dictionary<string, object>();
            try
            {
                if (mandateid == "0")
                {
                     Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<SaveData0>().With<SaveData1>().With<SaveData2>().With<SaveData3>().With<SaveData4>().With<SaveData5>().With<SaveData6>().With<SaveData7>().With<SaveData8>().Execute("@QueryType", "@SponsorCode", "@UtilityCode", "@DebitType", "@Frequency", "@UserId", "@EntityId",
                         "@ToDebit", "@AcNo", "@BankName", "@IFSC", "@MICR", "@AmountRupees", "@Refrence1", "@Refrence2", "@PhNumber",
                                 "@EmailId", "@From", "@To", "@Customer1", "@Customer2", "@Customer3", "@DateOnMandate", "@MandateMode", "@AmountWords", "@CategoryCode", "SaveData", savedata.Sponsorcode, savedata.Utilitycode, savedata.Debittype, savedata.Frequency, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))),
                                 savedata.Todebit, savedata.Bankaccountno, savedata.Withbank,
                        savedata.IFSC.ToUpper(), savedata.MICR.ToUpper(), savedata.Amountrupees, savedata.Refrence1, savedata.Refrence2, savedata.Phoneno, savedata.Email, savedata.PeriodFrom, savedata.PeriodTo, savedata.Customer1,
                        savedata.Customer2, savedata.Customer3, savedata.UMRNDATE, savedata.MandateMode, savedata.Amount, savedata.Catagorycode));
                }
                else
                {
                     Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<SaveData0>().With<SaveData1>().With<SaveData2>().With<SaveData3>().With<SaveData4>().With<SaveData5>().With<SaveData6>().With<SaveData7>().With<SaveData8>().Execute("@QueryType", "@SponsorCode", "@UtilityCode", "@DebitType", "@Frequency", "@UserId", "@EntityId",
                         "@ToDebit", "@AcNo", "@BankName", "@IFSC", "@MICR", "@AmountRupees", "@Refrence1", "@Refrence2", "@PhNumber",
                                 "@EmailId", "@From", "@To", "@Customer1", "@Customer2", "@Customer3", "@DateOnMandate", "@MandateMode", "@AmountWords", "@CategoryCode", "@MandateId", "UpdateData", savedata.Sponsorcode, savedata.Utilitycode, savedata.Debittype, savedata.Frequency, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))),
                                 savedata.Todebit, savedata.Bankaccountno, savedata.Withbank,
                        savedata.IFSC.ToUpper(), savedata.MICR.ToUpper(), savedata.Amountrupees, savedata.Refrence1, savedata.Refrence2, savedata.Phoneno, savedata.Email, savedata.PeriodFrom, savedata.PeriodTo, savedata.Customer1,
                        savedata.Customer2, savedata.Customer3, savedata.UMRNDATE, savedata.MandateMode, savedata.Amount, savedata.Catagorycode,mandateid));
                }
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindGrid(string UserId)
        {
            try
            {

                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<BindGrid>().Execute("@QueryType", "@UserId", "grdMandate", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%")))));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> Edit(string mandateid, string UserId, string EntityId)
        {
            try
            {



                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<EditData0>().With<EditData1>().With<EditData2>().With<EditData3>().With<EditData4>().Execute("@QueryType", "@MandateId", "@UserId", "@EntityId", "EditMandate", mandateid, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> ChecKmandate(string mandateId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<ChecKmandate>().Execute("@QueryType", "@MandateId", "ChecKmandate", mandateId));                
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> RemoveImage(string mandateId)
        {
            try
            {
                List<RemoveImage> dataList = new List<RemoveImage>();
               
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<RemoveImage>().Execute("@QueryType", "@MandateId", "RemoveImage", mandateId));
                foreach (var Logindata in Result)
                {
                   
                }

                   
                //    File.Delete(HttpContext.Current.Server.MapPath(Convert.ToString(dt.Rows[0]["JPGPath"])));
                //File.Delete(HttpContext.Current.Server.MapPath(Convert.ToString(dt.Rows[0]["TIPPath"])));
                //string temp = "../FullMandate/" + DbSecurity.Decrypt(mandateId) + "/" + ConfigurationManager.AppSettings["DownloadFileName"].ToString() + "_" + DateTime.Now.ToString("ddMMyyyy") + "_" + Convert.ToString(dt.Rows[0]["Refrence1"]) + ".jpg";
                //string fullpath = HttpContext.Current.Server.MapPath(temp);
                //File.Delete(fullpath);
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> UpdateAutoRejectReasonBankValidation(string mandateid, string UserId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<SaveData8>().Execute("@QueryType", "@MandateId", "@UserId", "UpdateAutoRejectReasonBankValidation", mandateid, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> UpdateFirst(string mandateid, string UserId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<SaveData0>().With<SaveData1>().With<SaveData2>().With<SaveData3>().With<SaveData4>().With<SaveData5>().With<SaveData6>().With<SaveData16>().Execute("@QueryType", "@MandateId", "@UserId", "UpdateIsFirstvalidation", mandateid, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}