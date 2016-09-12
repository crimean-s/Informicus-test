using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using System.Data.Entity;
using static Informicus_test_project.Models.Entities;

using System.Web.Configuration;
using System.Configuration;

namespace Informicus_test_project
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer<SiteContext>(new SiteContextInitializer());
        }
    }
}
