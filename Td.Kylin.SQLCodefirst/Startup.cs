using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;

namespace Td.Kylin.SQLCodeFirst
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
               .AddSqlServer()
               .AddDbContext<DataContext>(options =>
                   options.UseSqlServer(Configuration["Data:DefaultConnectionString"]));
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
