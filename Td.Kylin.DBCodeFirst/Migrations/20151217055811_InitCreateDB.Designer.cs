using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Td.Kylin.DBCodeFirst;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20151217055811_InitCreateDB")]
    partial class InitCreateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
        }
    }
}
