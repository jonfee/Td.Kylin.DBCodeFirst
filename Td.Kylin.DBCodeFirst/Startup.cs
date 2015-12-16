﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Entity;

namespace Td.Kylin.DBCodeFirst
{
    public class Startup
    {
        public static IConfigurationRoot Configuration { get; private set; }

        public Startup(IHostingEnvironment evt)
        {
            var builder = new ConfigurationBuilder()
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
    }
}
