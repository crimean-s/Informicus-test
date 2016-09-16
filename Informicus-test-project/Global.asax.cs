using System.Web.Mvc;
using System.Web.Routing;

using System.Data.Entity;
using Domain;
using static Domain.DbContext;

namespace Informicus_test_project
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer<Domain.DbContext>(new SiteContextInitializer());
        }
    }
}
