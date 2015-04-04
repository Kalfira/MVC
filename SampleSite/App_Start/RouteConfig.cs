using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SampleSite.Controllers;

namespace SampleSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] {typeof (PostsController).Namespace};

            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, namespaces }
            );

            routes.MapRoute(
                name: "Posts",
                url: "Posts",
                defaults: new { controller = "Posts", action = "Index", id = UrlParameter.Optional, SampleSite.Controllers.PostsController }
            );

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Login",
               url: "Auth/Login",
               defaults: new { controller = "Auth", action = "Login", id = UrlParameter.Optional, namespaces }
           );
        }
    }
}
