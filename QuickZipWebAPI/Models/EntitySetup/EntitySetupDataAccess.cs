using BusinessLibrary;
using QuickZipWebAPI.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using QuickZipWebAPI.Models.EntitySetup;


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

        public Dictionary<string, object> DeleteDataDataAccess(MainGrid MainGrid,string EntityId)
        {
            string[] authorsList = MainGrid.Code.Split(new char[] { ',' });
            string XmlEntity = "<dtXml>";
            for (int i=0; i< authorsList.Length-1; i++)
            {
                XmlEntity += "<dtXml ";
                XmlEntity += " dtEntityId=" + @"""" + Convert.ToInt64(authorsList[i]) +  @"""";
                XmlEntity += " />";
    }
            XmlEntity += "</dtXml>";
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<MainGrid>().Execute("@QueryType","@XmlEntity" ,"DeleteEntityXml", XmlEntity));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }








        public Dictionary<string, object> SaveDataDataAccess(AllFieldOfForm allFieldOfForm, string EntityId)
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

                var data = "To"; var NEWDATA = "Untill Cancelled";
                XmlType = "<dtXml>";
                XmlType += "<dtXml ";

                XmlType += "Value=" + @"""" + data + @"""";
                if (allFieldOfForm.To_Ch == true)
                {
                    XmlType += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlType += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlType += " />";

                XmlType += "<dtXml ";
                XmlType += "Value=" + @"""" + NEWDATA + @"""";
                if (allFieldOfForm.UntillCancelled_Ch == true)
                {
                    XmlType += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlType += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlType += " />";
                XmlType += "</dtXml>";
                ////////////////////////////////////
                var SB = "SB"; var CA = "CA"; var CC = "CC"; var SB_NRE = "SB-NRE"; var SB_NRO = "SB-NRO"; var Other = "Other";
                XmlToDebit = "<dtXml>";
                XmlToDebit += "<dtXml ";
                XmlToDebit += "Value=" + @"""" + SB + @"""";
                if (allFieldOfForm.SB_Ch == true)
                {
                    XmlToDebit += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlToDebit += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlToDebit += " />";
                XmlToDebit += "<dtXml ";
                XmlToDebit += "Value=" + @"""" + CA + @"""";
                if (allFieldOfForm.CA_Ch == true)
                {
                    XmlToDebit += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlToDebit += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlToDebit += " />";
                XmlToDebit += "<dtXml ";
                XmlToDebit += "Value=" + @"""" + CC + @"""";
                if (allFieldOfForm.CC_Ch == true)
                {
                    XmlToDebit += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlToDebit += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlToDebit += " />";
                XmlToDebit += "<dtXml ";
                XmlToDebit += "Value=" + @"""" + SB_NRE + @"""";
                if (allFieldOfForm.SB_NRE_Ch == true)
                {
                    XmlToDebit += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlToDebit += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlToDebit += " />";
                XmlToDebit += "<dtXml ";
                XmlToDebit += "Value=" + @"""" + SB_NRO + @"""";
                if (allFieldOfForm.SB_NRO_Ch == true)
                {
                    XmlToDebit += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlToDebit += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlToDebit += " />";
                XmlToDebit += "<dtXml ";
                XmlToDebit += "Value=" + @"""" + Other + @"""";
                if (allFieldOfForm.Other_Ch == true)
                {
                    XmlToDebit += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlToDebit += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlToDebit += " />";
                XmlToDebit += "</dtXml>";
                ////////////////////////////////////////////////////////////////
                var Monthly = "Monthly"; var Quarterly = "Quarterly"; var Half_Yearly = "Half-Yearly"; var Yearly = "Yearly";
                var AsandWhenPresented = "As and When Presented";
                Xmlfrequency = "<dtXml>";
                Xmlfrequency += "<dtXml ";
                Xmlfrequency += "Value=" + @"""" + Monthly + @"""";
                if (allFieldOfForm.Monthly_Ch == true)
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 0 + @"""";
                }
                Xmlfrequency += " />";
                Xmlfrequency += "<dtXml ";
                Xmlfrequency += "Value=" + @"""" + Quarterly + @"""";
                if (allFieldOfForm.Quarterly_Ch == true)
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 0 + @"""";
                }
                Xmlfrequency += " />";
                Xmlfrequency += "<dtXml ";
                Xmlfrequency += "Value=" + @"""" + Half_Yearly + @"""";
                if (allFieldOfForm.Half_Yearly_Ch == true)
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 0 + @"""";
                }
                Xmlfrequency += " />";
                Xmlfrequency += "<dtXml ";
                Xmlfrequency += "Value=" + @"""" + Yearly + @"""";
                if (allFieldOfForm.Yearly_Ch == true)
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 0 + @"""";
                }
                Xmlfrequency += " />";
                Xmlfrequency += "<dtXml ";
                Xmlfrequency += "Value=" + @"""" + AsandWhenPresented + @"""";
                if (allFieldOfForm.Presented_Ch == true)
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 0 + @"""";
                }
                Xmlfrequency += " />";
                Xmlfrequency += "</dtXml>";
                /////////////////////////////////////////////////////////////
                var FixedAmount = "Fixed Amount"; var MaximumAmount = "Maximum Amount";
                Xmldebittype = "<dtXml>";
                Xmldebittype += "<dtXml ";
                Xmldebittype += "Value=" + @"""" + FixedAmount + @"""";
                if (allFieldOfForm.FixedAmount_Ch == true)
                {
                    Xmldebittype += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    Xmldebittype += " IsEnable=" + @"""" + 0 + @"""";
                }
                Xmldebittype += " />";
                Xmldebittype += "<dtXml ";
                Xmldebittype += "Value=" + @"""" + MaximumAmount + @"""";
                if (allFieldOfForm.MaximumAmount_Ch == true)
                {
                    Xmldebittype += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    Xmldebittype += " IsEnable=" + @"""" + 0 + @"""";
                }
                Xmldebittype += " />";
                Xmldebittype += "</dtXml>";
                ////////////////////////////////////////////////////////
                dtPaymentMode = "<dtXml>";
                var Cash = "Cash"; var Cheque = "Cheque"; var DD = "DD"; var E = "E";
                if (allFieldOfForm.Cash_Ch == true)
                {
                    dtPaymentMode += "<dtXml ";
                    dtPaymentMode += "PaymentMode=" + @"""" + Cash + @"""";
                    dtPaymentMode += " />";
                }
                if (allFieldOfForm.Cheque_Ch == true)
                {
                    dtPaymentMode += "<dtXml ";
                    dtPaymentMode += "PaymentMode=" + @"""" + Cheque + @"""";
                    dtPaymentMode += " />";
                }
                if (allFieldOfForm.DemandDraft_Ch == true)
                {
                    dtPaymentMode += "<dtXml ";
                    dtPaymentMode += "PaymentMode=" + @"""" + DD + @"""";
                    dtPaymentMode += " />";
                }
                if (allFieldOfForm.Electronic_Ch == true)
                {
                    dtPaymentMode += "<dtXml ";
                    dtPaymentMode += "PaymentMode=" + @"""" + E + @"""";
                    dtPaymentMode += " />";
                }
                dtPaymentMode += "</dtXml>";
                ///////////////////////////////////////////////////////////////
                XmlModeType = "<dtXml>";
                XmlModeType += "<dtXml ";
                if (allFieldOfForm.IsPhysicalMandateCh == true)
                {
                    XmlModeType += " Physical=" + @"""" + 1 + @"""";

                    if (allFieldOfForm.ValidationByCustomer_Ch == true)
                    {
                        XmlModeType += " customer=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " customer=" + @"""" + 0 + @"""";
                    }
                    if (allFieldOfForm.ValidationByCorporate_Ch == true)
                    {
                        XmlModeType += " cooperate=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " cooperate=" + @"""" + 0 + @"""";
                    }
                    if (allFieldOfForm.OCRCode_Ch == true)
                    {
                        XmlModeType += " ocr=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " ocr=" + @"""" + 0 + @"""";
                    }
                }
                else
                {
                    XmlModeType += " Physical=" + @"""" + 0 + @"""";
                    XmlModeType += " customer=" + @"""" + 0 + @"""";
                    XmlModeType += " cooperate=" + @"""" + 0 + @"""";
                    XmlModeType += " ocr=" + @"""" + 0 + @"""";
                }
                if (allFieldOfForm.QRCode_Ch == true)
                {
                    XmlModeType += " Qr=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlModeType += " Qr=" + @"""" + 0 + @"""";
                }
                if (allFieldOfForm.Logo_Ch == true)
                {
                    XmlModeType += " logo=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlModeType += " logo=" + @"""" + 0 + @"""";
                }
                if (allFieldOfForm.PhoneNumber_ch == true)
                {
                    XmlModeType += " CustomerphNumber=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlModeType += " CustomerphNumber=" + @"""" + 0 + @"""";
                }
                if (allFieldOfForm.E_mailID_Ch == true)
                {
                    XmlModeType += " Customeremailid=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlModeType += " Customeremailid=" + @"""" + 0 + @"""";
                }
                if (allFieldOfForm.IsEMandate == true)
                {
                    XmlModeType += " emandate=" + @"""" + 1 + @"""";

                    if (allFieldOfForm.NetBankingCh == true)
                    {
                        XmlModeType += " netbanking=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " netbanking=" + @"""" + 0 + @"""";
                    }
                    if (allFieldOfForm.DebitCardCh == true)
                    {
                        XmlModeType += " debit=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " debit=" + @"""" + 0 + @"""";
                    }
                    if (allFieldOfForm.AadhaarCardCh == true)
                    {
                        XmlModeType += " aadhar=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " aadhar=" + @"""" + 0 + @"""";
                    }
                }
                else
                {
                    XmlModeType += " emandate=" + @"""" + 0 + @"""";
                }

                if (allFieldOfForm.NetBankingCh == true)
                {
                    if (allFieldOfForm.ValidateThroughEmail_Ch == true)
                    {
                        XmlModeType += " mail=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " mail=" + @"""" + 0 + @"""";
                    }
                    if (allFieldOfForm.Manual_Ch == true)
                    {
                        XmlModeType += " netmanual=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " netmanual=" + @"""" + 0 + @"""";
                    }
                    if (allFieldOfForm.SMS_Ch == true)
                    {
                        XmlModeType += " sms=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " sms=" + @"""" + 0 + @"""";
                    }
                }
                else
                {
                    XmlModeType += " mail=" + @"""" + 0 + @"""";
                    XmlModeType += " netmanual=" + @"""" + 0 + @"""";
                    XmlModeType += " sms=" + @"""" + 0 + @"""";
                }

                if (allFieldOfForm.DebitCardCh == true)
                {
                    if (allFieldOfForm.DebitValidateThroughEmail == true)
                    {
                        XmlModeType += " debitmail=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " debitmail=" + @"""" + 0 + @"""";
                    }
                    if (allFieldOfForm.DebitManual == true)
                    {
                        XmlModeType += " debitmanual=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " debitmanual=" + @"""" + 0 + @"""";
                    }
                    if (allFieldOfForm.DebitSMS == true)
                    {
                        XmlModeType += " debitsms=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " debitsms=" + @"""" + 0 + @"""";
                    }
                }
                else
                {
                    XmlModeType += " debitmail=" + @"""" + 0 + @"""";
                    XmlModeType += " debitmanual=" + @"""" + 0 + @"""";
                    XmlModeType += " debitsms=" + @"""" + 0 + @"""";
                }

                if (allFieldOfForm.AadhaarCardCh == true)
                {
                    if (allFieldOfForm.AadhaarValidateThroughEmail == true)
                    {
                        XmlModeType += " aadharmail=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " aadharmail=" + @"""" + 0 + @"""";
                    }
                    if (allFieldOfForm.AadhaarManual == true)
                    {
                        XmlModeType += " aadharmanual=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " aadharmanual=" + @"""" + 0 + @"""";
                    }
                    if (allFieldOfForm.AadhaarSMS == true)
                    {
                        XmlModeType += " aadharsms=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " aadharsms=" + @"""" + 0 + @"""";
                    }
                }
                else
                {
                    XmlModeType += " aadharmail=" + @"""" + 0 + @"""";
                    XmlModeType += " aadharmanual=" + @"""" + 0 + @"""";
                    XmlModeType += " aadharsms=" + @"""" + 0 + @"""";
                }

                if (allFieldOfForm.Accountvalidation_Ch == true)
                {
                    XmlModeType += " accountvalidation=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlModeType += " accountvalidation=" + @"""" + 0 + @"""";
                }

                if (allFieldOfForm.Presentment_Ch == true)
                {
                    XmlModeType += " Presentment=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlModeType += " Presentment=" + @"""" + 0 + @"""";
                }

                XmlModeType += " />";
                XmlModeType += "</dtXml>";





                dtBankAmount = "<dtXml></dtXml>";
                dtBankCode = "<dtXml></dtXml>";
                XmlFileName = "<dtXml></dtXml>";
                dtBankAmount = "<dtXml></dtXml>";
                dtEntityCode = "<dtXml></dtXml>";
                EntityBCode = "<dtXml></dtXml>";



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

                if (EntityId.Trim() == "N")

                {

                    var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<CommonClass>().With<CommonClass>().Execute(
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

                    return Result;
                }
                else
                {
                    var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<CommonClass>().With<CommonClass>().Execute(
                   "@QueryType", "@InstructingMemberId", "@XmlSponsorBankCode", "@Type","@EntityId" ,"@Code", "@Name", "@ContactPerson",
               "@SponsorBankCode", "@UtilityCode", "@SponsorBankName", "@UserId", "@Addr1", "@Email", "@CountryId", "@CityId", "@StateId",
                       "@Mobile", "@Pincode", "@ImagePath", "@UserName", "@password", "@passwordKey"
                       , "@DebitType", "@FrequencyType", "@ToDebit", "@Amount", "@Activate", "@XmlPaymentMode", "@EntityBusinessCode", "@IsOverMandate", "@IsRefrenceCheck",
                        "@IsValidationCountEnable",
                         "@BankValidationAdminCount", "@BankValidationUserCount", "@AcValidationAdminCount", "@AcValidationUserCount", "@IsRefNumerc",
                         "@IsShowMandateMode", "@IsSendEmailCustomer", "@IschkEmandate", "@IschkPhysical", "@Xmldebittype", "@XmlToDebit", "@XmlType", "@Xmlfrequency", "@chkIsRefrence2Mandatory", "@dtBankAmount", "@IsThirdTransaction",
                         "@chkIsZipSure", "@chkIsAllowEManadte", "@ISTodateMandatoryEnach", "@APPId", "@XmlFileName", "@AccountNumber", "@ReCheck", "@CheckerRequire", "@XmlModeType", "@IsEnableUserCheck", "@ISEnableCancelUser", "@MerchantKey", "@dtEntityCode",
                        "UpdateData", allFieldOfForm.InstructingMenmerId, dtBankCode, allFieldOfForm.Type, EntityId , allFieldOfForm.Code, allFieldOfForm.EntityName,

                       allFieldOfForm.Name, allFieldOfForm.BankCode, allFieldOfForm.UtilityCode, allFieldOfForm.BankName, UserId, allFieldOfForm.Address, allFieldOfForm.Email, allFieldOfForm.Country, allFieldOfForm.City

                       , allFieldOfForm.State, allFieldOfForm.MobileNo, allFieldOfForm.PinCode, allFieldOfForm.FullPath, allFieldOfForm.UserName, password, passwordKey,

                       allFieldOfForm.DebitType, allFieldOfForm.FrequencyType, allFieldOfForm.ToDebit, allFieldOfForm.Amount, Activate, dtPaymentMode, EntityBCode, IsOverPrintMandate, IsRefCheck_Ch, IsValidationCountEnableCh

                       , allFieldOfForm.BankValidationAdminCount, allFieldOfForm.BankValidationUserCount, allFieldOfForm.AcValidationAdminCount, allFieldOfForm.AcValidationUserCount, IsRefNumerc, IsShowMandateMode, IsSendEmail, IsEMandate,

                       IsPhysicalMandateCh, Xmldebittype, XmlToDebit, XmlType, Xmlfrequency, chkIsRefrence2Mandatory, dtBankAmount, IsThirdTransactionCh, chkIsZipSure_Ch,

                       chkIsAllowEManadte_Ch, ISTodateMandatoryEnach_Ch,

                      allFieldOfForm.AppID, XmlFileName, allFieldOfForm.AccountNumber, recheckthepresentmentfileCh, CheckerRequire, XmlModeType, EnableUserWise_Ch, ISEnableCancelUser, allFieldOfForm.MerchantKey, dtEntityCode
                      ));
                    return Result;
                }
                
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

        public Dictionary<string, object> EditDataDataAccess(string EntityId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<EditDataClass1>().With<EditDataClass2>().With<EditDataClass3>().With<EditDataClass4>().
                   With<EditDataAny>().With<EditdataClass5>().With<EditDataClass6>().With<EditDataClass7>().With<EditDataClass8>().With<EditDataClass9>().With<EditDataClass10>().
                   With<EditDataClass11>().With<EditDataClass12>().With<EditDataClass13>().With<EditDataClass14>().Execute("@QueryType", "@EntityId", "EditEntity", EntityId));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}