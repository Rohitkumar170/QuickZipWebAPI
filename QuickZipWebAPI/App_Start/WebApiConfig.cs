using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace QuickZipWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {  
            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}/{id1}/{id2}/{id3}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
