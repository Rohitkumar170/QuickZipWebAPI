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


    }
}