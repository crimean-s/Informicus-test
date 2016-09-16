using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Informicus_test_project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "RegisterUser",
                url: "Register/{action}/{id}",
                defaults: new { controller = "Register", action = "RegisterUser", id = UrlParameter.Optional },
                constraints: new { id = @"\d+" }
            );
        }
    }
}
