﻿using SistemaEscolar.Classes;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SistemaEscolar
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Models.ControleContext, Migrations.Configuration>());
            CkeckRoles();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void CkeckRoles()
        {
            Utilidades.CheckRole("Admin");
            Utilidades.CheckRole("Professor");
            Utilidades.CheckRole("Estudante");
        }
    }
}
