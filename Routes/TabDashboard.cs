using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using CustomRoutes;

namespace Tab {

    public class Dashboard : ICustomRoutesDashBoards {

        // ICustomRoutesDashBoards CustomRoutes  =  new ICustomRoutesDashBoards();
        public void injectRoutes(IRouteBuilder routes) {
            routes.MapRoute(name: "tab", template: "{controller=Tab}/{action=Index}");
            // routes.MapRoute(name: "tab", template: "{controller=Tab}/{action=Add}/{id?}");
            // routes.MapRoute(name: "tab", template: "{controller=Tab}/{action=Delete/{id?}");
            Console.WriteLine("---- new router config ----");
        }
    }

}
