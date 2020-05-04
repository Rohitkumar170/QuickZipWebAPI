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
namespace QuickZipWebAPI.Models.Link_setup
{
    public class Link_setup
    {
        QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        List<BindGrid> dataList = new List<BindGrid>();

        public Dictionary<string, object> BindGrid()
        {

            try
            {

                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<BindGrid>().Execute("@QueryType", "BindGridLinkItems"));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> GetIconDropDown()
        {

            try
            {

                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<IconName>().Execute("@QueryType", "GetIcons"));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Dictionary<string, object> EditData(string LinkId)
        {

            try
            {

                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<BindGrid>().Execute("@QueryType", "@LinkID", "EditLinks",LinkId));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }

           
        }
        public IEnumerable<BindGrid> InsertData(BindGrid link, string UserId)
        {
            try
            {
                string IsActive = "0";

                if (Convert.ToString(link.IsActive) == "True")
                {
                    IsActive = "1";
                }
                else
                {
                    IsActive = "0";

                }

                var Result = dbcontext.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<BindGrid>().Execute("@QueryType", "@LinkName", "@url", "@Purpose", "@IconName", "@OrderNo", "@IsActive", "@Createdby", "InsertLinks", link.LinkName, link.url, link.Purpose, link.IconName, Convert.ToString(link.OrderNo), IsActive, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))));

                foreach (var link1 in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = link1.Cast<BindGrid>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<BindGrid> UpDateLink(BindGrid link, string UserId,string LinkId)
        {
            try
            {
                string IsActive = "0";

                if (Convert.ToString(link.IsActive) == "True")
                {
                    IsActive = "1";
                }
                else
                {
                    IsActive = "0";

                }

                var Result = dbcontext.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<BindGrid>().Execute("@QueryType", "@LinkID", "@LinkName", "@url", "@Purpose", "@IconName", "@OrderNo", "@IsActive", "@Createdby", "UpDateLinks", LinkId,
                    link.LinkName, link.url, link.Purpose, link.IconName, Convert.ToString(link.OrderNo), IsActive, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))));

                foreach (var link1 in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = link1.Cast<BindGrid>().ToList();
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