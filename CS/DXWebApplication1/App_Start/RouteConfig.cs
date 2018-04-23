using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DevExpress.DashboardWeb.Mvc;

namespace DXWebApplication1 {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.ashx/{*pathInfo}");
            routes.MapDashboardRoute("dashboardDesigner", "MyDashboard", new string[] { "DXWebApplication1.Controllers" }); 
            routes.MapRoute(
                name: "Default", // Route name
                url: "{controller}/{action}/{id}", // URL with parameters
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }
    }
}