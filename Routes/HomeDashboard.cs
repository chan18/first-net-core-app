using System;
using Microsoft.AspNetCore.Routing;

namespace Home {
    class Dashboard {
        public void injectRoute(IRouteBuilder routes) {
            // routes.MapRoute(name: "default",template: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}