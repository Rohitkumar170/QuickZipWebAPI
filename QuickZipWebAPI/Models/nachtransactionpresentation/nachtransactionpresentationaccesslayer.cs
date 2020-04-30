﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickZipWebAPI.Entity;
using BusinessLibrary;
namespace QuickZipWebAPI.Models.nachtransactionpresentation
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

                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<Nachtransactionpresentation>().Execute("@QueryType", "@UserId", "@EntityId", "Dropdown", UserId, EntityId);
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
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionCheckUser>().Execute("@QueryType", "@UserId", "@EntityId", "CheckUser", UserId, EntityId));
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
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionPrsentationBindForm>().Execute("@QueryType", "@Bank_ID", "@UserId", "@EntityId", "BindBankDropdownData", Bank, UserId, EntityId);
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
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionMainGrid>().Execute("@QueryType", "@UserId", "BindHeaderData", UserId);
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
        public IEnumerable<NachTransactionBindUMRN> BindUMRN(string UserId,string EntityId,string PresDate)
        {
            try

            {
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionBindUMRN>().Execute("@QueryType", "@UserId", "@EntityId", "@PresDate", "BindUMRN", UserId, EntityId, PresDate);
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
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionBindRef>().Execute("@QueryType", "@UserId", "@EntityId", "@PresDate", "BindRef", UserId, EntityId, PresDate);
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
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionBindRow>().Execute("@QueryType", "@UserId", "@EntityId", "@Fileno", "EditPresentation", UserId, EntityId, FileNo);
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
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionBindRow>().Execute("@QueryType", "@UserId", "@EntityId", "@UMRN", "BindRefrenceOnChange", UserId, EntityId, UMRN);
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
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<NachTransactionUMRNOnChange>().Execute("@QueryType", "@UserId", "@EntityId", "@Refrence1", "BindUMRNOnChange", UserId, EntityId, RefrenceNo);
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