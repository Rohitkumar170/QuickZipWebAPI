using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickZipWebAPI.Entity;
using BusinessLibrary;

namespace QuickZipWebAPI.Models.Allumrn
{
    public class Allumrnaccesslayer
    {

        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        List<GridData> dataList = new List<GridData>();
        List<Insertumrn> dataList1 = new List<Insertumrn>();
        List<GridDataDetails> dataList2 = new List<GridDataDetails>();

        //public IEnumerable<GridData> GridBind(string Entityid, string Pageno)
        //{
        //    try
        //    {

        //        var Result = dbcontext.MultipleResults("[dbo].[Sp_Uploaddata]").With<GridData>().Execute("@QueryType", "@PageCount", "@EntityID", "UMRNUpload", Pageno, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(Entityid.Replace("_", "%"))));
        //        foreach (var employe in Result)
        //        {

        //            dataList = employe.Cast<GridData>().ToList();
        //        }
        //        return dataList;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public Dictionary<string, object> GridBind1(string Entityid, string Pageno)
        {
            try
            {

                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Uploaddata]").With<GridData>().With<Paging>().Execute("@QueryType", "@PageCount", "@EntityID", "UMRNUpload", Pageno, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(Entityid.Replace("_", "%")))));
                return Result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public IEnumerable<GridData> SearchData(GridData UMRN)
        {
            try
            {

                var Result = dbcontext.MultipleResults("[dbo].[Sp_Uploaddata]").With<GridData>().Execute("@QueryType", "@UMRN", "@CustomerName", "@Refrence", "@EntityID", "@PageCount", "UMRNUpload", UMRN.UMRN, UMRN.CustomerName, UMRN.ReferenceNumber, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UMRN.Entityid.Replace("_", "%"))), UMRN.Pageno);
                foreach (var Data in Result)
                {
                    dataList = Data.Cast<GridData>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> SearchData1(GridData UMRN)
        {
            try
            {

                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Uploaddata]").With<GridData>().With<Paging>().Execute("@QueryType", "@UMRN", "@CustomerName", "@Refrence", "@EntityID", "@PageCount", "UMRNUpload", UMRN.UMRN, UMRN.CustomerName, UMRN.ReferenceNumber, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UMRN.Entityid.Replace("_", "%"))), UMRN.Pageno));

                return Result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //DataSet dt = CommonManger.FillDatasetWithParam("Sp_Presenment", "@QueryType", "@EntityId", "@UMRN", "EachUMRNHistoryDetails", DbSecurity.Decrypt(EntityId), UMRN);BindGridDetails

        public IEnumerable<GridDataDetails> GridDataDetails(string UMRN, string Entityid)
        {
            try
            {

                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<GridDataDetails>().Execute("@QueryType", "@UMRN", "@EntityID", "EachUMRNHistoryDetails", UMRN, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(Entityid.Replace("_", "%"))));
                foreach (var employe in Result)
                {

                    dataList2 = employe.Cast<GridDataDetails>().ToList();
                }
                return dataList2;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public Dictionary<string, object> GridDataDetails1(string UMRN, string Entityid)
        //{
        //    try
        //    {

        //        var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<Grid1>().With<Grid2>().With<Grid3>().Execute("@QueryType", "@UMRN", "@EntityID", "EachUMRNHistoryDetails", UMRN, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(Entityid.Replace("_", "%")))));

        //        return Result;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public IEnumerable<Insertumrn> AddUmrn(Insertumrn Umrn)
        //{
        //    try
        //    {
        //        var Result = dbcontext.MultipleResults("[dbo].[Sp_Uploaddata]").With<Insertumrn>().Execute("@QueryType", "@UMRN", "@Refrence", "@Amount", "@FromDate", "@ToDate", "@CreatedBy", "@UserId", "@EntityId", "InsertData", Umrn.UMRN, Umrn.ReferenceNumber, Umrn.Amount, Umrn.FromDate, Umrn.ToDate, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(Umrn.CreatedBy.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(Umrn.UserId.Replace("_", "%"))) , DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(Umrn.EntityId.Replace("_", "%"))) );

        //        //return Result;

        //        foreach (var Insertumrn1 in Result)
        //        {
        //            //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
        //            dataList1 = Insertumrn1.Cast<Insertumrn>().ToList();
        //        }
        //        return dataList1;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public Dictionary<string, object> AddUmrn1(Insertumrn Umrn)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Uploaddata]").With<Insertumrn>().Execute("@QueryType", "@UMRN", "@Refrence", "@Amount", "@FromDate", "@ToDate", "@CreatedBy", "@UserId", "@EntityId", "InsertData", Umrn.UMRN, Umrn.ReferenceNumber, Umrn.Amount, Umrn.FromDate, Umrn.ToDate, Umrn.CreatedBy, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(Umrn.UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(Umrn.EntityId.Replace("_", "%")))));

                return Result;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}