using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using tzunami_test.DAL;
using tzunami_test.Models;

namespace tzunami_test
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            InitContext();
        }

        private void InitContext()
        {
            UsersFactory.Users.InsertUser(new Student { FirstName = "Ariel", LastName = "Omstein", PhoneNumber = "0155555555", EMail = "a@Omstein.a" });
            UsersFactory.Users.InsertUser(new Alumni { FirstName = "Itay", LastName = "Sagui", PhoneNumber = "025555555", EMail = "a@Sagui.a" });
            UsersFactory.Users.InsertUser(new Lecturer { FirstName = "Nimrod", LastName = "Berger", PhoneNumber = "035555555", EMail = "a@Berger.a" });
        }
    }
}
