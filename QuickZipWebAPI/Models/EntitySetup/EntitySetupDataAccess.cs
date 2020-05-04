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
                string XmlModeType = "";
                string dtEntityCode = "";
                string EntityBCode = "";
                string UserId = "0";
               
                string Activate = "";
                if (allFieldOfForm.Activate == true)
                {
                    Activate = "Y";
                }
                else
                {
                    Activate = "N";
                }
               string IsOverPrintMandate = "";
               if (allFieldOfForm.IsOverPrintMandate == true)
                {
                    IsOverPrintMandate = "1";
                }
                else
                {
                    IsOverPrintMandate = "0";
                }
                string IsRefCheck_Ch = "";
               if (allFieldOfForm.IsRefCheck_Ch == true)
                {
                    IsRefCheck_Ch = "1";
                }
                else
                {
                    IsRefCheck_Ch = "0";
                }
                string IsValidationCountEnableCh = "";
                if (allFieldOfForm.IsValidationCountEnableCh)
                {
                    IsValidationCountEnableCh = "1";
                }
                else
                {
                    IsValidationCountEnableCh = "0";
                }
                string IsRefNumerc = "";
                if (allFieldOfForm.IsRefNumerc == true)
                {
                    IsRefNumerc = "1";
                }
                else
                {
                    IsRefNumerc = "0";
                }
                string IsShowMandateMode = "";
                if (allFieldOfForm.IsShowMandateMode == true)
                {
                    IsShowMandateMode = "1";
                }
                else
                {
                    IsShowMandateMode = "0";
                }
                string IsSendEmail = "";
                if (allFieldOfForm.IsSendEmail == true)
                {
                    IsSendEmail = "1";
                }
                else
                {
                    IsSendEmail = "0";
                }
                string IsEMandate = "";
                if (allFieldOfForm.IsEMandate == true)
                {
                    IsEMandate = "1";
                }
                else
                {
                    IsEMandate = "0";
                }
                string IsPhysicalMandateCh = "";
                if (allFieldOfForm.IsPhysicalMandateCh == true)
                {
                    IsPhysicalMandateCh = "1";
                }
                else
                {
                    IsPhysicalMandateCh = "0";
                }
                string chkIsRefrence2Mandatory = "";
                if(allFieldOfForm.chkIsRefrence2Mandatory == true)
                {
                    chkIsRefrence2Mandatory = "1";
                }
                else
                {
                    chkIsRefrence2Mandatory = "0";
                }
                string IsThirdTransactionCh = "";
                if (allFieldOfForm.IsThirdTransactionCh == true)
                {
                    IsThirdTransactionCh = "1";
                }
                else
                {
                    IsThirdTransactionCh = "0";
                }
                string chkIsZipSure_Ch = "";
                if (allFieldOfForm.chkIsZipSure_Ch == true)
                {
                    chkIsZipSure_Ch = "1";
                }
                else
                {
                    chkIsZipSure_Ch = "0";
                }
                string chkIsAllowEManadte_Ch = "";
                if (allFieldOfForm.chkIsAllowEManadte_Ch == true)
                {
                    chkIsAllowEManadte_Ch = "1";
                }
                else
                {
                    chkIsAllowEManadte_Ch = "0";
                }
                string ISTodateMandatoryEnach_Ch = "";
                if (allFieldOfForm.ISTodateMandatoryEnach_Ch == true)
                {
                    ISTodateMandatoryEnach_Ch = "1";
                }
                else
                {
                    ISTodateMandatoryEnach_Ch = "0";
                }
                string recheckthepresentmentfileCh = "";
                if(allFieldOfForm.recheckthepresentmentfileCh == true)
                {
                    recheckthepresentmentfileCh = "1";
                }
                else
                {
                    recheckthepresentmentfileCh = "0";
                }
                string CheckerRequire = "";
                if(allFieldOfForm.CheckerRequire == true)
                {
                    CheckerRequire = "1";
                }
                else
                {
                    CheckerRequire = "0";
                }
                string EnableUserWise_Ch = "";
                if(allFieldOfForm.EnableUserWise_Ch == true)
                {
                    EnableUserWise_Ch = "1";
                }
                else
                {
                    EnableUserWise_Ch = "0";
                }
                string ISEnableCancelUser = "";
                if(allFieldOfForm.ISEnableCancelUser == true)
                {
                    ISEnableCancelUser = "1";
                }
                else
                {
                    ISEnableCancelUser = "0";
                }

                dtBankCode = "<dtXml></dtXml>";
                XmlFileName = "<dtXml></dtXml>";
                dtBankAmount = "<dtXml></dtXml>";
                dtEntityCode = "<dtXml></dtXml>";
                EntityBCode = "<dtXml></dtXml>";

                XmlType = "<dtXml>";
                //XmlType += "<dtXml ";
                //XmlType += "Value='"+"To"+"'";
                //if (allFieldOfForm.To_Ch == true)
                //{
                //    XmlType += "IsEnable='" + "1" + "'";
                //}
                //else
                //{
                //    XmlType += "IsEnable='" + "0" + "'";
                //}
                //XmlType += "/>";
                //XmlType += "<dtXml ";
                //XmlType += "Value='" + "Untill Cancelled" + "'";
                //if (allFieldOfForm.UntillCancelled_Ch == true)
                //{
                //    XmlType += "IsEnable='" + "1" + "'";
                //}
                //else
                //{
                //    XmlType += "IsEnable='" + "0" + "'";
                //}
                //XmlType += "/>";
                XmlType += "</dtXml>";
              ///////////////////////////////////////
                XmlToDebit = "<dtXml>";
                //XmlToDebit += "<dtXml ";
                //XmlToDebit += "Value='" + "SB" + "'";
                //if (allFieldOfForm.SB_Ch == true)
                //{
                //    XmlToDebit += "IsEnable='" + "1" + "'";
                //}
                //else
                //{
                //    XmlToDebit += "IsEnable='" + "0" + "'";
                //}
                //XmlToDebit += "/>";
                //XmlToDebit += "<dtXml ";
                //XmlToDebit += "Value='" + "CA" + "'";
                //if (allFieldOfForm.CA_Ch == true)
                //{
                //    XmlToDebit += "IsEnable='" + "1" + "'";
                //}
                //else
                //{
                //    XmlToDebit += "IsEnable='" + "0" + "'";
                //}
                //XmlToDebit += "/>";
                //XmlToDebit += "<dtXml ";
                //XmlToDebit += "Value='" + "CC" + "'";
                //if (allFieldOfForm.CC_Ch == true)
                //{
                //    XmlToDebit += "IsEnable='" + "1" + "'";
                //}
                //else
                //{
                //    XmlToDebit += "IsEnable='" + "0" + "'";
                //}
                //XmlToDebit += "/>";
                //XmlToDebit += "<dtXml ";
                //XmlToDebit += "Value='" + "SB-NRE" + "'";
                //if (allFieldOfForm.SB_NRE_Ch == true)
                //{
                //    XmlToDebit += "IsEnable='" + "1" + "'";
                //}
                //else
                //{
                //    XmlToDebit += "IsEnable='" + "0" + "'";
                //}
                //XmlToDebit += "/>";
                //XmlToDebit += "<dtXml ";
                //XmlToDebit += "Value='" + "SB-NRO" + "'";
                //if (allFieldOfForm.SB_NRO_Ch == true)
                //{
                //    XmlToDebit += "IsEnable='" + "1" + "'";
                //}
                //else
                //{
                //    XmlToDebit += "IsEnable='" + "0" + "'";
                //}
                //XmlToDebit += "/>";
                //XmlToDebit += "<dtXml ";
                //XmlToDebit += "Value='" + "Other" + "'";
                //if (allFieldOfForm.Other_Ch == true)
                //{
                //    XmlToDebit += "IsEnable='" + "1" + "'";
                //}
                //else
                //{
                //    XmlToDebit += "IsEnable='" + "0" + "'";
                //}
                //XmlToDebit += "/>";
                XmlToDebit += "</dtXml>";
                ////////////////////////////////////////////////////////////////
                Xmlfrequency = "<dtXml>";
                //Xmlfrequency += "<dtXml ";
                //Xmlfrequency += "Value='" + "Monthly" + "'";
                //if (allFieldOfForm.Monthly_Ch == true)
                //{
                //    Xmlfrequency += "IsEnable='" + "1" + "'";
                //}
                //else
                //{
                //    Xmlfrequency += "IsEnable='" + "0" + "'";
                //}
                //Xmlfrequency += "/>";
                //Xmlfrequency += "<dtXml ";
                //Xmlfrequency += "Value='" + "Quarterly" + "'";
                //if (allFieldOfForm.Quarterly_Ch == true)
                //{
                //    Xmlfrequency += "IsEnable='" + "1" + "'";
                //}
                //else
                //{
                //    Xmlfrequency += "IsEnable='" + "0" + "'";
                //}
                //Xmlfrequency += "/>";
                //Xmlfrequency += "<dtXml ";
                //Xmlfrequency += "Value='" + "Half-Yearly" + "'";
                //if (allFieldOfForm.Half_Yearly_Ch == true)
                //{
                //    Xmlfrequency += "IsEnable='" + "1" + "'";
                //}
                //else
                //{
                //    Xmlfrequency += "IsEnable='" + "0" + "'";
                //}
                //Xmlfrequency += "/>";
                //Xmlfrequency += "<dtXml ";
                //Xmlfrequency += "Value='" + "Yearly" + "'";
                //if (allFieldOfForm.Yearly_Ch == true)
                //{
                //    Xmlfrequency += "IsEnable='" + "1" + "'";
                //}
                //else
                //{
                //    Xmlfrequency += "IsEnable='" + "0" + "'";
                //}
                //Xmlfrequency += "/>";
                //Xmlfrequency += "<dtXml ";
                //Xmlfrequency += "Value='" + "As and When Presented" + "'";
                //if (allFieldOfForm.Presented_Ch == true)
                //{
                //    Xmlfrequency += "IsEnable='" + "1" + "'";
                //}
                //else
                //{
                //    Xmlfrequency += "IsEnable='" + "0" + "'";
                //}
                //Xmlfrequency += "/>";
                Xmlfrequency += "</dtXml>";
                /////////////////////////////////////////////////////////////
                Xmldebittype = "<dtXml>";
                //Xmldebittype += "<dtXml ";
                //Xmldebittype += "Value=" + "" +"Fixed Amount" +"" + "";
                //if (allFieldOfForm.FixedAmount_Ch == true)
                //{
                //    Xmldebittype += "IsEnable=" + ""+ "1" +""+ "";
                //}
                //else
                //{
                //    Xmldebittype += "IsEnable='" + "0" + "'";
                //}
                //Xmldebittype += "/>";
                //Xmldebittype += "<dtXml ";
                //Xmldebittype += "Value='" + "Maximum Amount" + "'";
                //if (allFieldOfForm.MaximumAmount_Ch == true)
                //{
                //    Xmldebittype += "IsEnable='" + "1" + "'";
                //}
                //else
                //{
                //    Xmldebittype += "IsEnable='" + "0" + "'";
                //}
                //Xmldebittype += "/>";
                Xmldebittype += "</dtXml>";
                //////////////////////////////////////////////////////
                dtPaymentMode = "<dtXml>";
                //dtPaymentMode += "<dtXml ";
                //if (allFieldOfForm.Cash_Ch == true)
                //{
                //    dtPaymentMode += "PaymentMode='" + "Cash" + "'";
                //    dtPaymentMode += "/>";
                //}
                //if (allFieldOfForm.Cheque_Ch == true)
                //{
                //    dtPaymentMode += "PaymentMode='" + "Cheque" + "'";
                //    dtPaymentMode += "/>";
                //}
                //if (allFieldOfForm.DemandDraft_Ch == true)
                //{
                //    dtPaymentMode += "PaymentMode='" + "DD" + "'";
                //    dtPaymentMode += "/>";
                //}
                //if (allFieldOfForm.Electronic_Ch == true)
                //{
                //    dtPaymentMode += "PaymentMode='" + "E" + "'";
                //    dtPaymentMode += "/>";
                //}
                dtPaymentMode += "</dtXml>";
                ///////////////////////////////////////////////////////////////
                XmlModeType = "<dtXml></dtXml>";
                //XmlModeType += "<dtXml ";
                //if (allFieldOfForm.IsPhysicalMandateCh == true)
                //{
                //    XmlModeType += "Physical='" + "1" + "'";
                //}

                dtBankAmount = "<dtXml></dtXml>";





                string password = string.Empty;
                allFieldOfForm.confirmpassword = "";
                string passwordKey = string.Empty;
                //if (allFieldOfForm.confirmpassword.Trim() != "")
                //{

                //    //password = DbSecurity.Encrypt(confirmpassword, ref passwordKey);
                //    allFieldOfForm.confirmpassword = Convert.ToString(ConfigurationManager.AppSettings["DefaultPswdEntity"]);
                //    password = DbSecurity.Encrypt(allFieldOfForm.confirmpassword, ref passwordKey);
                //}
                //if (allFieldOfForm.UserId == "undefined")
                //{
                //    UserId = "0";
                //}

                //if (EntityId.Trim() == "")

                //{

                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<CommonClass>().Execute(
                    "@QueryType", "@InstructingMemberId", "@XmlSponsorBankCode", "@Type", "@Code", "@Name", "@ContactPerson",
                "@SponsorBankCode", "@UtilityCode", "@SponsorBankName", "@UserId", "@Addr1", "@Email", "@CountryId", "@CityId", "@StateId",
                        "@Mobile", "@Pincode", "@ImagePath", "@UserName", "@password", "@passwordKey"
                        , "@DebitType", "@FrequencyType", "@ToDebit", "@Amount", "@Activate", "@XmlPaymentMode", "@EntityBusinessCode", "@IsOverMandate", "@IsRefrenceCheck",
                         "@IsValidationCountEnable",
                          "@BankValidationAdminCount", "@BankValidationUserCount", "@AcValidationAdminCount", "@AcValidationUserCount", "@IsRefNumerc",
                          "@IsShowMandateMode", "@IsSendEmailCustomer", "@IschkEmandate", "@IschkPhysical", "@Xmldebittype", "@XmlToDebit", "@XmlType", "@Xmlfrequency", "@chkIsRefrence2Mandatory", "@dtBankAmount", "@IsThirdTransaction",
                          "@chkIsZipSure", "@chkIsAllowEManadte", "@ISTodateMandatoryEnach", "@APPId", "@XmlFileName", "@AccountNumber", "@ReCheck", "@CheckerRequire", "@XmlModeType", "@IsEnableUserCheck", "@ISEnableCancelUser", "@MerchantKey", "@dtEntityCode",
                         "SaveData", allFieldOfForm.InstructingMenmerId, dtBankCode, allFieldOfForm.Type, allFieldOfForm.Code, allFieldOfForm.EntityName,

                        allFieldOfForm.Name, allFieldOfForm.BankCode, allFieldOfForm.UtilityCode, allFieldOfForm.BankName, UserId, allFieldOfForm.Address, allFieldOfForm.Email, allFieldOfForm.Country, allFieldOfForm.City

                        , allFieldOfForm.State, allFieldOfForm.MobileNo, allFieldOfForm.PinCode, allFieldOfForm.FullPath, allFieldOfForm.UserName, password, passwordKey,

                        allFieldOfForm.DebitType, allFieldOfForm.FrequencyType, allFieldOfForm.ToDebit, allFieldOfForm.Amount, Activate, dtPaymentMode, EntityBCode, IsOverPrintMandate, IsRefCheck_Ch, IsValidationCountEnableCh

                        , allFieldOfForm.BankValidationAdminCount, allFieldOfForm.BankValidationUserCount, allFieldOfForm.AcValidationAdminCount, allFieldOfForm.AcValidationUserCount, IsRefNumerc, IsShowMandateMode, IsSendEmail , IsEMandate,

                        IsPhysicalMandateCh , Xmldebittype, XmlToDebit, XmlType, Xmlfrequency, chkIsRefrence2Mandatory , dtBankAmount, IsThirdTransactionCh , chkIsZipSure_Ch,

                        chkIsAllowEManadte_Ch, ISTodateMandatoryEnach_Ch ,

                       allFieldOfForm.AppID, XmlFileName, allFieldOfForm.AccountNumber, recheckthepresentmentfileCh , CheckerRequire, XmlModeType, EnableUserWise_Ch, ISEnableCancelUser, allFieldOfForm.MerchantKey, dtEntityCode
                       ));


                //}
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindStateDataAccess(string CountryId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<BindState>().Execute("@QueryType","@CountryId", "Bindstate", CountryId));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> BindCityDataAccess(string StateId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<BindCity>().Execute("@QueryType", "@StateId", "BindCity", StateId));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}