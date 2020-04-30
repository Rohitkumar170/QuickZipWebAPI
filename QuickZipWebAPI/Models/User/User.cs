using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLibrary;
using System.Threading.Tasks;
using QuickZipWebAPI.Entity;
using System.Xml.Linq;
using System.Net.Http;
using System.Xml;

namespace QuickZipWebAPI.Models.User
{
    public class User
    {
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        List<Users> dataList = new List<Users>();
        public Dictionary<string, object> GetAllUsers(string EntityId, string PageCount, string Search_Text)
        {
            try
            {


                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_user]").With<UserData>().With<UtilityCodes>().With<SponsorBankCode>().With<EntityPaymentMode>().With<UserEntity>().With<EntityMandateMode>().With<TempData>().With<CategoryCodes>().Execute("@QueryType", "@EntityId", "@PageCount", "@Search_Text", "BindUser", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), PageCount, Search_Text));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> GetAllMakers(string EntityId, string UserId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_user]").With<Maker>().With<NachUser>().Execute("@QueryType", "@EntityId", "@UserId", "BindPresentmentMaker", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> CheckIsPresentmentChecker(string EntityId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<Checker>().With<AccessRights>().With<AccessRights>().Execute("@QueryType", "@EntityId", "CheckIsPresentmentChecker", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> getUserReportData(string EntityId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_user]").With<UserReport>().Execute("@QueryType", "@EntityId", "ExportExcel_UserGrid", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> EditUserData(string UserId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[sp_user]").With<UserData>().With<getsponsorcode>().With<getutilitycode>().With<getPaymentMode>().With<getMaker>().With<getAccessRights>().With<getAccessRights>().With<getIsPresent>().With<getAccessRights>().With<getCategoryCode>().Execute("@QueryType", "@UserId", "Edit", UserId));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Users> SaveUserData(Users userdata, string EntityId, string UserId, string dtUserRights_1, string dtUserRights_2, string dtSponsorBankCode, string dtCategoryCode, string dtPresentmentMaker, int chkPresentMaker, int chkPresentChecker, int IsZipSure, int IsAllowFundTransfer, int IsMandateEdit, int Ismandate, int IsBulk, int iSDashboard, int IsEnableCancel, int IsViewAll, string Defaultpwd, string dtPaymentMode, string dtUserRights_3, string dtUserRights_4, int chkRefEdit)
        {
            try
            {


                string password = "";
                string passwordKey = "";

                if (Defaultpwd.Trim() != "")
                {
                    Defaultpwd = Convert.ToString(ConfigurationManager.AppSettings["DefaultPswdUser"]);
                    password = DbSecurity.Encrypt(Defaultpwd, ref passwordKey);


                }


                var Result = dbcontext.MultipleResults("[dbo].[sp_user]").With<Users>().Execute("@QueryType", "@XmlSponsorBankCode", "@EntityId", "@Type"
                , "@UserId", "@ContactNo", "@EmailId", "@userNameId",
         "@password", "@passwordKey", "@XmlPaymentMode", "@IsBulkMandate", "@IsMandate", "@IsMandateEdit", "@IsRefrenceEdit",
         "@EmailSendTo", "@IsAllowFundTransfer", "@IsZipSure", "@APPId", "@PresentmentMaker", "@PresentmentChecker", "@XmlPresentmentMaker", "@XmlUserRightsA", "@XmlUserRightsB", "@XmlUserRightsC", "@XmlUserRightsD", "@NachViewUserID", "@IsDashBoard", "@IsEnableCancel", "@BankValidationUserCount", "@AcValidationUserCount", "@IsViewAll", "@XmlCategoryCode", "SaveData"
                       , dtSponsorBankCode, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), userdata.Type, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), userdata.PhoneNo, userdata.EmailId, userdata.UserName,
             password, passwordKey, dtPaymentMode, IsBulk.ToString(), Ismandate.ToString(), IsMandateEdit.ToString(), chkRefEdit.ToString(), userdata.emailsent, IsAllowFundTransfer.ToString(), IsZipSure.ToString(), Convert.ToString(ConfigurationManager.AppSettings["APPId"]), chkPresentMaker.ToString(), chkPresentChecker.ToString(), dtPresentmentMaker, dtUserRights_1, dtUserRights_2, dtUserRights_3, dtUserRights_4, userdata.nachuser, iSDashboard.ToString(), IsEnableCancel.ToString(), Convert.ToString(userdata.bankval), Convert.ToString(userdata.accountval), IsViewAll.ToString(), dtCategoryCode);

                foreach (var usrdata in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = usrdata.Cast<Users>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }






        public IEnumerable<Users> UpdateUserData(Users userdata, string EntityId, string UserId, string dtUserRights_1, string dtUserRights_2, string dtSponsorBankCode, string dtCategoryCode, string dtPresentmentMaker, int chkPresentMaker, int chkPresentChecker, int IsZipSure, int IsAllowFundTransfer, int IsMandateEdit, int Ismandate, int IsBulk, int iSDashboard, int IsEnableCancel, int IsViewAll, string Defaultpwd, string dtPaymentMode, string dtUserRights_3, string dtUserRights_4, int chkRefEdit, int Id)
        {
            try
            {

                string password = "";
                string passwordKey = "";

                if (Defaultpwd.Trim() != "")
                {
                    Defaultpwd = Convert.ToString(ConfigurationManager.AppSettings["DefaultPswdUser"]);
                    password = DbSecurity.Encrypt(Defaultpwd, ref passwordKey);


                }


                var Result = dbcontext.MultipleResults("[dbo].[sp_user]").With<Users>().Execute("@QueryType", "@XmlSponsorBankCode", "@EntityId", "@Type"
                , "@UserId", "@ContactNo", "@EmailId", "@userNameId",
         "@password", "@passwordKey", "@XmlPaymentMode", "@IsBulkMandate", "@IsMandate", "@IsMandateEdit", "@IsRefrenceEdit",
         "@EmailSendTo", "@IsAllowFundTransfer", "@IsZipSure", "@APPId", "@PresentmentMaker", "@PresentmentChecker", "@XmlPresentmentMaker", "@XmlUserRightsA", "@XmlUserRightsB", "@XmlUserRightsC", "@XmlUserRightsD", "@NachViewUserID", "@IsDashBoard", "@IsEnableCancel", "@BankValidationUserCount", "@AcValidationUserCount", "@IsViewAll", "@XmlCategoryCode", "@User", "UpdateData"
                       , dtSponsorBankCode, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), userdata.Type, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), userdata.PhoneNo, userdata.EmailId, userdata.UserName,
             password, passwordKey, dtPaymentMode, IsBulk.ToString(), Ismandate.ToString(), IsMandateEdit.ToString(), chkRefEdit.ToString(), userdata.emailsent, IsAllowFundTransfer.ToString(), IsZipSure.ToString(), Convert.ToString(ConfigurationManager.AppSettings["APPId"]), chkPresentMaker.ToString(), chkPresentChecker.ToString(), dtPresentmentMaker, dtUserRights_1, dtUserRights_2, dtUserRights_3, dtUserRights_4, userdata.nachuser, iSDashboard.ToString(), IsEnableCancel.ToString(), Convert.ToString(userdata.bankval), Convert.ToString(userdata.accountval), IsViewAll.ToString(), dtCategoryCode, Id.ToString());

                foreach (var usrdata in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = usrdata.Cast<Users>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}