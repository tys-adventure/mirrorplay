using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mirror_Play
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("SpecificRoute", "{action}/{id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Users",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "users", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Videos",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "videos", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
