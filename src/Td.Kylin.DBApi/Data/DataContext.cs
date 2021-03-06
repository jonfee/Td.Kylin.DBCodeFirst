﻿using System;
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
            string sqltype = Startup.Configuration["Data:SqlType"];
            switch (sqltype.ToLower())
            {
                case "pgsql":
                    optionsBuilder.UseNpgsql(connection);
                    break;
                case "mssql":
                default:
                    optionsBuilder.UseSqlServer(connection);
                    break;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //系统模块接口授权
            modelBuilder.Entity<System_ModuleAuthorize>(entity =>
            {
                entity.HasKey(p => new { p.ServerID, p.ModuleID });
            });

            //管理员账户
            modelBuilder.Entity<Admin_Account>(entity =>
            {
                entity.Property(p => p.AdminID).ValueGeneratedNever();
                entity.HasKey(p => p.AdminID);
            });

            //商家行业
            modelBuilder.Entity<Merchant_Industry>(entity =>
            {
                entity.Property(p => p.IndustryID).ValueGeneratedNever();
                entity.HasKey(p => p.IndustryID);
            });

            #region 平台提供的商家服务业务

            modelBuilder.Entity<KylinService_Business>(entity =>
            {
                entity.Property(p => p.BusinessID).ValueGeneratedNever();
                entity.HasKey(p => p.BusinessID);
            });

            modelBuilder.Entity<KylinService_BusinessOptions>(entity =>
            {
                entity.Property(p => p.OptionID).ValueGeneratedNever();
                entity.HasKey(p => p.OptionID);
            });

            modelBuilder.Entity<KylinService_BusinessConfig>(entity =>
            {
                entity.HasKey(p => new { p.BusinessID, p.OptionID });
            });

            #endregion

            #region 区域
            modelBuilder.Entity<System_Area>(entity =>
            {
                entity.Property(p => p.AreaID).ValueGeneratedNever();
                entity.HasKey(p => p.AreaID);
            });
            #endregion

            #region 全局

            //系统模块接口授权
            modelBuilder.Entity<System_ModuleAuthorize>(entity =>
            {
                entity.HasKey(p => new { p.ServerID, p.ModuleID });
            });

            //系统全局配置
            modelBuilder.Entity<System_GlobalResources>(entity =>
            {
                entity.HasKey(p => new { p.ResourceType, p.ResourceKey });
            });

            //系统积分配置
            modelBuilder.Entity<System_PointsConfig>(entity =>
            {
                entity.Property(p => p.ActivityType).ValueGeneratedNever();
                entity.HasKey(p => p.ActivityType);
            });
            
            //系统经验值配置
            modelBuilder.Entity<System_EmpiricalConfig>(entity =>
            {
                entity.Property(p => p.ActivityType).ValueGeneratedNever();
                entity.HasKey(p => p.ActivityType);
            });

            //系统用户等级配置
            modelBuilder.Entity<System_Level>(entity =>
            {
                entity.Property(p => p.LevelID).ValueGeneratedNever();
                entity.HasKey(p => p.LevelID);
            });

            #endregion

            //广告页
            modelBuilder.Entity<Ad_Page>(entity =>
            {
                entity.Property(p => p.PageID).ValueGeneratedNever();
                entity.HasKey(p => p.PageID);
            });

            /// <summary>
            /// 广告位
            /// </summary>
            modelBuilder.Entity<Ad_Position>(entity =>
            {
                entity.Property(p => p.PositionID).ValueGeneratedNever();
                entity.HasKey(p => p.PositionID);
            });
        }
    }
}
