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

        public IEnumerable<GridData> SearchData(string Entityid, string Pageno)
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

        

           public IEnumerable<GridData> Searchbtn(GridData UMRNHistoryClass)
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
    }
}