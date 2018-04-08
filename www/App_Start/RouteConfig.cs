using System.Web.Mvc;
using System.Web.Routing;

namespace www
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection Routes)
        {
            Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            Routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Web", action = "ComingSoon", id = UrlParameter.Optional }
            );
        }
    }
}
