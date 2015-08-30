using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HoustonFreeways
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ViewSwitcher",
                url: "ViewSwitcher/SwitchView",
                defaults: new { controller = "ViewSwitcher", action = "SwitchView" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{action}/{id}/{item}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, item = UrlParameter.Optional }
            );


        }
    }
}