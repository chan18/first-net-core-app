using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Tab {

    class Dashboard {
        public void injectTabRoutes(IRouteBuilder routes) {
            routes.MapRoute(name: "tab", template: "{controller=Tab}/{action=Index}");
            // routes.MapRoute(name: "tab", template: "{controller=Tab}/{action=Add}/{id?}");
            // routes.MapRoute(name: "tab", template: "{controller=Tab}/{action=Delete/{id?}");
            Console.WriteLine("---- new router config ----");
        }

    }

}