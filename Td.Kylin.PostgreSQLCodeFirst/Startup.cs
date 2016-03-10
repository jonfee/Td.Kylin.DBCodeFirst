using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.Data.Entity;

namespace Td.Kylin.PostgreSQLCodeFirst
{
    public class Startup
    {
        public static IConfigurationRoot Configuration { get; private set; }

        public Startup(IHostingEnvironment evt, IApplicationEnvironment appEvn)
        {
            var builder = new ConfigurationBuilder().SetBasePath(appEvn.ApplicationBasePath)
               .AddJsonFile("config.json");

            Configuration = builder.Build();
        }

        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFramework()
               .AddNpgsql()
               .AddDbContext<DataContext>(options =>
                   options.UseNpgsql(Configuration["Data:DefaultConnectionString"]));
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
