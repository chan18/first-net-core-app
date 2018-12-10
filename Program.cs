using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace tabscomponent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("\n");

            Console.Write("---- .net core is botting ------");

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder
         CreateWebHostBuilder(string[] args) => WebHost.CreateDefaultBuilder(args)
                                                        .ConfigureAppConfiguration((hostingContext, config) => {
                                                            Console.Write(" \t \t .....Configuring-APP...... \n");
                                                            // Console.Write(hostingContext+"\t"+config+"\n");
                                                        })
                                                        .UseStartup<Startup>();
    }
}
