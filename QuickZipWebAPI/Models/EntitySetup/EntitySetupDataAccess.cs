using BusinessLibrary;
using QuickZipWebAPI.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;


namespace QuickZipWebAPI.Models.EntitySetup
{
    public class EntitySetupDataAccess
    {
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        public Dictionary<string, object> BindCountryAndBank()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<BindCountry>().With<BindBank>().With<EntityBusinessCode>().Execute("@QueryType", "BindCountry"));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> BindGridDataAccess()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<MainGrid>().Execute("@QueryType", "BindEntity"));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> SaveDataDataAccess(AllFieldOfForm allFieldOfForm)
        {
            try
            {
                string dtBankCode = "";
                string Xmldebittype = "";
                string XmlToDebit = "";
                string XmlType = "";
                string Xmlfrequency = "";
                string XmlFileName = "";
                string dtBankAmount = "";
                string dtPaymentMode = "";
                string UserId = "0";




                string password = string.Empty;
                string passwordKey = string.Empty;
                if (allFieldOfForm.confirmpassword.Trim() != "")
                {

                    //password = DbSecurity.Encrypt(confirmpassword, ref passwordKey);
                    allFieldOfForm.confirmpassword = Convert.ToString(ConfigurationManager.AppSettings["DefaultPswdEntity"]);
                    password = DbSecurity.Encrypt(allFieldOfForm.confirmpassword, ref passwordKey);
                }
                //if (allFieldOfForm.UserId == "undefined")
                //{
                //    UserId = "0";
                //}

                //if (EntityId.Trim() == "")

                //{

                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<MainGrid>().Execute(
                    "Sp_Entity", "@QueryType", "@InstructingMemberId", "@XmlSponsorBankCode", "@Type", "@Code", "@Name", "@ContactPerson",
                "@SponsorBankCode", "@UtilityCode", "@SponsorBankName", "@UserId", "@Addr1", "@Email", "@CountryId", "@CityId", "@StateId",
                        "@Mobile", "@Pincode", "@ImagePath", "@UserName", "@password", "@passwordKey"
                        , "@DebitType", "@FrequencyType", "@ToDebit", "@Amount", "@Activate", "@XmlPaymentMode", "@EntityBusinessCode", "@IsOverMandate", "@IsRefrenceCheck",
                         "@IsValidationCountEnable",
                          "@BankValidationAdminCount", "@BankValidationUserCount", "@AcValidationAdminCount", "@AcValidationUserCount", "@IsRefNumerc",
                          "@IsShowMandateMode", "@IsSendEmailCustomer", "@IschkEmandate", "@IschkPhysical", "@Xmldebittype", "@XmlToDebit", "@XmlType", "@Xmlfrequency", "@chkIsRefrence2Mandatory", "@dtBankAmount", "@IsThirdTransaction",
                          "@chkIsZipSure", "@chkIsAllowEManadte", "@ISTodateMandatoryEnach", "@APPId", "@XmlFileName", "@AccountNumber", "@ReCheck", "@CheckerRequire", "@XmlModeType", "@IsEnableUserCheck", "@ISEnableCancelUser", "@MerchantKey", "@dtEntityCode",
                         "SaveData", allFieldOfForm.InstructingMenmerId, dtBankCode, allFieldOfForm.Type, allFieldOfForm.Code, allFieldOfForm.EntityName,

                        allFieldOfForm.Name, allFieldOfForm.BankCode, allFieldOfForm.UtilityCode, allFieldOfForm.BankName, DbSecurity.Decrypt(UserId), allFieldOfForm.Address, allFieldOfForm.Email, allFieldOfForm.Country, allFieldOfForm.City

                        , allFieldOfForm.State, allFieldOfForm.MobileNo, allFieldOfForm.PinCode, allFieldOfForm.FullPath, allFieldOfForm.UserName, password, passwordKey,

                        allFieldOfForm.DebitType, allFieldOfForm.FrequencyType, allFieldOfForm.ToDebit, allFieldOfForm.Amount, allFieldOfForm.Activate, dtPaymentMode, allFieldOfForm.EntityBCode, Convert.ToString(allFieldOfForm.IsOverPrintMandate), Convert.ToString(allFieldOfForm.IsRefCheck_Ch), Convert.ToString(allFieldOfForm.IsValidationCountEnableCh)

                        , allFieldOfForm.BankValidationAdminCount, allFieldOfForm.BankValidationUserCount, allFieldOfForm.AcValidationAdminCount, allFieldOfForm.AcValidationUserCount, Convert.ToString(allFieldOfForm.IsRefNumerc), Convert.ToString(allFieldOfForm.IsShowMandateMode), Convert.ToString(allFieldOfForm.IsSendEmail), Convert.ToString(allFieldOfForm.IsEMandate),

                        Convert.ToString(allFieldOfForm.IsPhysicalMandateCh), Xmldebittype, XmlToDebit, XmlType, Xmlfrequency, Convert.ToString(allFieldOfForm.chkIsRefrence2Mandatory), dtBankAmount, Convert.ToString(allFieldOfForm.IsThirdTransactionCh), Convert.ToString(allFieldOfForm.chkIsZipSure_Ch),

                        Convert.ToString(allFieldOfForm.chkIsAllowEManadte_Ch), Convert.ToString(allFieldOfForm.ISTodateMandatoryEnach_Ch),

                       allFieldOfForm.AppID, XmlFileName, allFieldOfForm.AccountNumber, Convert.ToString(allFieldOfForm.ReCheck), Convert.ToString(allFieldOfForm.CheckerRequire), allFieldOfForm.XmlModeType, Convert.ToString(allFieldOfForm.IsEnableUserCheck), Convert.ToString(allFieldOfForm.ISEnableCancelUser), allFieldOfForm.MerchantKey, allFieldOfForm.dtEntityCode
                       ));


                //}
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}