
using System;
using Microsoft.AspNetCore.Routing;

namespace CustomRoutes
{
     interface ICustomRoutesDashBoards
    {
        void injectRoutes(IRouteBuilder routes);

    }

}