using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using Tab;
using CustomRoutes;

namespace tabscomponent
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Console.Write(" ---- Startup and configureing Services like cookies, mvc, database configs and route configs  --- \n ");
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                Console.Write(" --- setup cookies --- \n \n \n ");
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddCors();

            Console.Write("--- add mvc service and set version ---- \n ");
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // services.AddScoped<ICustomRoutesDashBoards,Dashboard>();

            Console.Write(" ----- setting database ---- \n ");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            Console.Write("---- setting up the Https request pipelin ---- \n ");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                // Console.Write(" ---- setting up the routes ----- \n ");
                routes.MapRoute(
                    name: "default",
                    template: "{Home}/{index}/{id?}",
                    defaults: new { controller = "Home", action = "index"}
                );

            });

        }

    }
}
