using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Td.Kylin.SQLCodeFirst;

namespace Td.Kylin.SQLCodefirst
{
	public class Startup
	{
		public static IConfigurationRoot Configuration
		{
			get;
			private set;
		}

		public Startup(IHostingEnvironment env)
		{
			var builder = new ConfigurationBuilder().SetBasePath(env.ContentRootPath).AddJsonFile("config.json");

			Configuration = builder.Build();
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services
				.AddEntityFrameworkSqlServer()
				.AddEntityFramework()
				.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration["Data:DefaultConnectionString"]));
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if(env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.Run(async (context) =>
			{
				await context.Response.WriteAsync("complete!");
			});
		}
	}
}