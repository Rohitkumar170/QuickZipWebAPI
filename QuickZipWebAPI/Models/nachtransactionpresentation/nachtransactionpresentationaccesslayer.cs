using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLibrary;
using QuickZipWebAPI.Models.nachtransactionpresentation;
using QuickZipWebAPI.Entity;

namespace QuickZip.Models.nachtransactionpresentation
{
    public class nachtransactionpresentationaccesslayer
    {
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        List<Nachtransactionpresentation> dataList = new List<Nachtransactionpresentation>();
        List<NachTransactionPrsentationBindForm> dataList1 = new List<NachTransactionPrsentationBindForm>();
        List<NachTransactionMainGrid> dataList2 = new List<NachTransactionMainGrid>();
        List<NachTransactionBindUMRN> dataList3 = new List<NachTransactionBindUMRN>();
        List<NachTransactionBindRef> dataList4 = new List<NachTransactionBindRef>();
        List<NachTransactionBindRow> dataList5 = new List<NachTransactionBindRow>();
        List<NachTransactionBindRefOnChange> dataList6 = new List<NachTransactionBindRefOnChange>();
        List<NachTransactionUMRNOnChange> dataList7 = new List<NachTransactionUMRNOnChange>();




        //public Dictionary<string, object> BankBind(string UserId,string EntityId)
        public IEnumerable<Nachtransactionpresentation> BankBind(string UserId, string EntityId)
        {
            try

            {

                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<Nachtransactionpresentation>().Execute("@QueryType", "@UserId", "@EntityId", "Dropdown", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))));
                foreach (var Nachtransactionpresentation in Result)
                {
                    dataList = Nachtransactionpresentation.Cast<Nachtransactionpresentation>().ToList();

                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> CheckUser(string UserId, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionCheckUser>().Execute("@QueryType", "@UserId", "@EntityId", "CheckUser", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<NachTransactionPrsentationBindForm> BindGridForm(string Bank, string UserId, string EntityId)
        {
            try

            {
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionPrsentationBindForm>().Execute("@QueryType", "@Bank_ID", "@UserId", "@EntityId", "BindBankDropdownData", Bank, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))));
                foreach (var Nachtransaction in Result)
                {
                    dataList1 = Nachtransaction.Cast<NachTransactionPrsentationBindForm>().ToList();

                }
                return dataList1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<NachTransactionMainGrid> BindMainGrid(string UserId)
        {
            try

            {
                /*var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionMainGrid>().Execute("@QueryType", "@UserId", "BindHeaderData", UserId)*/;
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionMainGrid>().Execute("@QueryType", "@UserId", "BindHeaderData", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))));
                foreach (var Nachtransaction in Result)
                {
                    dataList2 = Nachtransaction.Cast<NachTransactionMainGrid>().ToList();

                }
                return dataList2;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<NachTransactionBindUMRN> BindUMRN(string UserId, string EntityId, string PresDate)
        {
            try

            {
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionBindUMRN>().Execute("@QueryType", "@UserId", "@EntityId", "@PresDate", "BindUMRN", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), PresDate);
                foreach (var Nachtransaction in Result)
                {
                    dataList3 = Nachtransaction.Cast<NachTransactionBindUMRN>().ToList();

                }
                return dataList3;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<NachTransactionBindRef> BindRefrence(string UserId, string EntityId, string PresDate)
        {
            try

            {
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionBindRef>().Execute("@QueryType", "@UserId", "@EntityId", "@PresDate", "BindRef", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), PresDate);
                foreach (var Nachtransaction in Result)
                {
                    dataList4 = Nachtransaction.Cast<NachTransactionBindRef>().ToList();

                }
                return dataList4;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<NachTransactionBindRow> BindOnRowdblClick(string UserId, string EntityId, string FileNo)
        {
            try

            {
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionBindRow>().Execute("@QueryType", "@UserId", "@EntityId", "@Fileno", "EditPresentation", UserId,EntityId, FileNo);
                //var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionBindRow>().Execute("@QueryType", "@UserId", "@EntityId", "@Fileno", "EditPresentation", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), FileNo);
                foreach (var Nachtransaction in Result)
                {
                    dataList5 = Nachtransaction.Cast<NachTransactionBindRow>().ToList();

                }
                return dataList5;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<NachTransactionBindRefOnChange> BindRefOnchange(string UserId, string EntityId, string UMRN)
        {
            try

            {
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionBindRefOnChange>().Execute("@QueryType", "@UserId", "@EntityId", "@UMRN", "BindRefrenceOnChange", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), UMRN);
                foreach (var Nachtransaction in Result)
                {
                    dataList6 = Nachtransaction.Cast<NachTransactionBindRefOnChange>().ToList();

                }
                return dataList6;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<NachTransactionUMRNOnChange> BindUMRNOnchange(string UserId, string EntityId, string RefrenceNo)
        {
            try

            {
                //var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionUMRNOnChange>().Execute("@QueryType", "@UserId", "@EntityId", "@Refrence1", "BindUMRNOnChange", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), EntityId, RefrenceNo);
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionUMRNOnChange>().Execute("@QueryType", "@UserId", "@EntityId", "@Refrence1", "BindUMRNOnChange", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), RefrenceNo);
                foreach (var Nachtransaction in Result)
                {
                    dataList7 = Nachtransaction.Cast<NachTransactionUMRNOnChange>().ToList();

                }
                return dataList7;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}