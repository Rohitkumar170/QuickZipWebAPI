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

        public IEnumerable<GridData> GridBind(string Entityid, string Pageno)
        {
            try
            {
               
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Uploaddata]").With<GridData>().Execute("@QueryType", "@PageCount", "@EntityID", "UMRNUpload", Pageno, Entityid);
                foreach (var employe in Result)
                {

                    dataList = employe.Cast<GridData>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

           public IEnumerable<GridData> SearchData(GridData UMRNHistoryClass)
        {
            try
            {
              
                   var Result = dbcontext.MultipleResults("[dbo].[Sp_Uploaddata]").With<GridData>().Execute("@QueryType", "@UMRN", "@CustomerName", "@Refrence", "@EntityID", "@PageCount", "UMRNUpload", UMRNHistoryClass.UMRN, UMRNHistoryClass.CustomerName, UMRNHistoryClass.ReferenceNumber,UMRNHistoryClass.Entityid,UMRNHistoryClass.Pageno);
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


        //DataSet dt = CommonManger.FillDatasetWithParam("Sp_Presenment", "@QueryType", "@EntityId", "@UMRN", "EachUMRNHistoryDetails", DbSecurity.Decrypt(EntityId), UMRN);BindGridDetails

        public IEnumerable<GridData> GridDataDetails(string UMRN, string Entityid)
        {
            try
            {

                var Result = dbcontext.MultipleResults("[dbo].[Sp_Presenment]").With<GridDataDetails>().Execute("@QueryType", "@UMRN", "@EntityID", "EachUMRNHistoryDetails", UMRN, Entityid);
                foreach (var employe in Result)
                {

                    dataList = employe.Cast<GridData>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<Insertumrn> AddUmrn(Insertumrn Umrn)
        {
            try
            {
                var Result = dbcontext.MultipleResults("[dbo].[Sp_Uploaddata]").With<Insertumrn>().Execute("@QueryType", "@UMRN", "@Refrence", "@Amount", "@FromDate", "@ToDate", "@CreatedBy", "@UserId", "@EntityId", "InsertData", Umrn.UMRN, Umrn.ReferenceNumber, Umrn.Amount, Umrn.FromDate, Umrn.ToDate, Umrn.CreatedBy, Umrn.UserId, Umrn.EntityId);

                //return Result;

                foreach (var Insertumrn1 in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList1 = Insertumrn1.Cast<Insertumrn>().ToList();
                }
                return dataList1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public Dictionary<string,object> AddUmrn(string NEWUMRN, string Customername, string ReferenceNumber, string Amount, string FromDate, string ToDate, string Entityid, string Userid, string CreatedBy)
        //{
        //    try
        //    {
        //        var Result1 = dbcontext.MultipleResults("[dbo].[Sp_Uploaddata]").With<Insertumrn>().Execute("@QueryType", "@UMRN", "@Refrence", "@Amount", "@FromDate", "@ToDate", "@CreatedBy", "@UserId", "@EntityId", "InsertData", NEWUMRN,ReferenceNumber, Amount, FromDate, ToDate, CreatedBy,Userid, Entityid);

        //        return Result1;



        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}