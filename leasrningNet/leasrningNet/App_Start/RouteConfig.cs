using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace leasrningNet
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            //routes.MapRoute(
            //    "MoviesByReleasesDate",
            //    "movies/released/{year}/{month}",
            //    new { controller = "Movie", action = "ByReleaseYear"},
            //    new {year = @"2015|2016", month = @"\d{2}"}
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Movie", action = "Random", id = UrlParameter.Optional }
            );
        }
    }
}
