using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Models.Login;
using QuickZipWebAPI.Models;

namespace QuickZipWebAPI.Controllers
{
    public class LoginController : ApiController
    {



        Login objlogin = new Login();
        [HttpGet]
        [Route("api/Login/getlogindetails/{Username}/{Password}")]
        public IEnumerable<CommonFlag> getlogindetails(string Username,string Password)
        {
            return objlogin.Binddetails(Username, Password);
        }
        [HttpGet]
        [Route("api/Login/ForgotPassword/{Username}")]
        public IEnumerable<CommonFlag> ForgotPassword(string Username)
        {
            return objlogin.SendMail(Username);
        }
        [HttpGet]
        [Route("api/Login/UpdatePassword/{Password}/{Email}")]
        public IEnumerable<CommonFlag> UpdatePassword(string Password, string Email)
        {
            return objlogin.UpdateForgot(Password, Email);
        }

    }
}
