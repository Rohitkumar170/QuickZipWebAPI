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


        public Dictionary<string, object> SaveData(SaveData savedata, string UserId, string EntityId)
        {
            try
            {
               
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<SaveData0>().With<SaveData1>().With<SaveData2>().With<SaveData3>().With<SaveData4>().With<SaveData5>().With<SaveData6>().With<SaveData7>().With<SaveData8>().Execute("@QueryType", "@SponsorCode", "@UtilityCode", "@DebitType", "@Frequency", "@UserId", "@EntityId",
                     "@ToDebit", "@AcNo", "@BankName", "@IFSC", "@MICR", "@AmountRupees", "@Refrence1", "@Refrence2", "@PhNumber",
                             "@EmailId", "@From", "@To", "@Customer1", "@Customer2", "@Customer3", "@DateOnMandate", "@MandateMode", "@AmountWords", "@CategoryCode", "SaveData", savedata.Sponsorcode, savedata.Utilitycode, savedata.Debittype, savedata.Frequency, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))),
                             savedata.Todebit, savedata.Bankaccountno, savedata.Withbank,
                    savedata.IFSC, savedata.MICR, savedata.Amountrupees, savedata.Refrence1, savedata.Refrence2, savedata.Phoneno, savedata.Email, savedata.PeriodFrom, savedata.PeriodTo, savedata.Customer1,
                    savedata.Customer2, savedata.Customer3, savedata.UMRNDATE, savedata.MandateMode, savedata.Amount, savedata.Catagorycode));
              
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}