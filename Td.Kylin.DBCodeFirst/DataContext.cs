using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Td.Kylin.DBCodeFirst.Models;

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
            #region 商家

            modelBuilder.Entity<Merchant_Industry>().HasKey(p => new { p.IndustryID });

            modelBuilder.Entity<Merchant_Account>().HasKey(p => new { p.MerchantID });

            modelBuilder.Entity<Merchant_Certificate>().HasKey(p => new { p.CertificateID });

            #endregion

            #region 用户

            modelBuilder.Entity<User_Account>().HasKey(p => new { p.UserID });

            modelBuilder.Entity<User_Address>().HasKey(p => new { p.AddressID });

            modelBuilder.Entity<User_Device>().HasKey(p => new { p.DeviceID });

            modelBuilder.Entity<User_Forum>().HasKey(p => new { p.UserID });

            modelBuilder.Entity<User_LocationTrack>().HasKey(p => new { p.TrackID });

            modelBuilder.Entity<User_Online>().HasKey(p => new { p.UserID });

            modelBuilder.Entity<User_Profile>().HasKey(p => new { p.UserID });

            modelBuilder.Entity<User_ShakeRecord>().HasKey(p => new { p.UserID });

            #endregion

            #region 摇一摇

            modelBuilder.Entity<Shake_Content>().HasKey(p => new
            {
                p.ContentID
            });

            modelBuilder.Entity<Shake_UserRecord>().HasKey(p => new
            {
                p.RecordID
            });

            #endregion

            #region 短信

            modelBuilder.Entity<System_SMS>().HasKey(p => new { p.Id });

            #endregion

            #region 系统模块接口授权

            modelBuilder.Entity<System_ModuleAuthorize>().HasKey(p => new { p.ServerID, p.ModuleID });

            #endregion
        }
    }
}
