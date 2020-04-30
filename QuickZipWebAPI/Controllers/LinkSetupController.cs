using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data;
using System.IO;
using ExcelDataReader;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Entity;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.OleDb;
using System.Text;
using System.Collections;
using System.Globalization;
using System.Data.SqlClient;
using QuickZipWebAPI.Models.Link_setup;
using QuickZipWebAPI.Models;
using System.Web;

namespace QuickZipWebAPI.Controllers
{
    public class LinkSetupController : ApiController
    {
        Link_setup linksetup = new Link_setup();


        [HttpGet]
        [Route("api/Link_setup/BindGrid")]
        public Dictionary<string, object> BindGrid()
        {

            return linksetup.BindGrid();
        }



        [HttpGet]
        [Route("api/Link_setup/GetIconDropDown")]
        public Dictionary<string, object> GetIconDropDown()
        {

            return linksetup.GetIconDropDown();
        }

        [HttpGet]
        [Route("api/Link_setup/EditData/{LinkId}")]
        public Dictionary<string, object> EditData(string LinkId)
        {

            return linksetup.EditData(LinkId);
        }
        [HttpPost]
        [Route("api/Link_setup/InsertData/{UserId}")]
        public IEnumerable<BindGrid> InsertData([FromBody] BindGrid link, string UserId)
        {
                       
            return linksetup.InsertData(link, UserId);
        }


        [HttpPost]
        [Route("api/Link_setup/UpDateLink/{UserId}/{LinkId}")]
        public IEnumerable<BindGrid> UpDateLink([FromBody] BindGrid link, string UserId,string LinkId)
        {

            return linksetup.UpDateLink(link, UserId, LinkId);
        }
    }
}
