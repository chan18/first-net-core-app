using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace tab {

    class Dashboard {
        public void injectTabRoute(IRouteBuilder routes) {
            routes.MapRoute(name: "tab", template: "{controller=Tab}/{action=Index}/{id?}");
            Console.WriteLine("---- new router config ----");
        }

    }

}