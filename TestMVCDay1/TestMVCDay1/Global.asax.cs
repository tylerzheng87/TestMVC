using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TestMVCDay1.Filters;

namespace TestMVCDay1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            GlobalFilters.Filters.Add(new CheckLoginFilter());
            GlobalFilters.Filters.Add(new LoginActionFilter());
            GlobalFilters.Filters.Add(new ExceptionFilter());
        }
    }
}
