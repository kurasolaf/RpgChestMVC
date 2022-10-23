using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgChestMVC.web
{
    public class Program
    {
        //////////////////////////////////////////////////
        //TO DO:
        //Add some VIEWS
        //Add some MODELS
        //Add some CONTROLLERS
        //
        //////////////////////////////////////////////////





        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

        }
        //re-write console app for web
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

       


    }
}
