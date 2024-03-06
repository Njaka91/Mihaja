using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mihaja
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
                name: "Accueil",
                url: "User/Index"
                );
            routes.MapRoute(
                name: "PageList",
                url: "Task/Index"
                ) ;
            routes.MapRoute(
               name: "AddModal",
               url: "Task/Modifier"
               );
        }
    }
}
