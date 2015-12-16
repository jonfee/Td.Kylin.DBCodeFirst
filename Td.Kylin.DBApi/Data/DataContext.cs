using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Td.Kylin.DBApi;
using Td.Kylin.Entity;

namespace Td.Kylin.DBCodeFirst
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public partial class DataContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = Startup.Configuration["Data:DefaultConnectionString"];
            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region 系统模块接口授权

            modelBuilder.Entity<System_ModuleAuthorize>().HasKey(p => new { p.ServerID, p.ModuleID });

            #endregion
        }
    }
}
