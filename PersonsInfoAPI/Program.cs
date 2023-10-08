using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
data:image/pjpeg;base64,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