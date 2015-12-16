using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
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
            #region 广告

            //广告页
            modelBuilder.Entity<Ad_Page>().HasKey(p => new { p.PageID });

            /// <summary>
            /// 广告位
            /// </summary>
            modelBuilder.Entity<Ad_Position>().HasKey(p => new { p.PositionID });

            /// <summary>
            /// 广告内容
            /// </summary>
            modelBuilder.Entity<Ad_Content>().HasKey(p => new { p.ContentID });

            #endregion

            #region 管理员

            /// <summary>
            /// 管理员账户
            /// </summary>
            modelBuilder.Entity<Admin_Account>().HasKey(p => new { p.AdminID });

            /// <summary>
            /// 管理员权限
            /// </summary>
            modelBuilder.Entity<Admin_Permission>().HasKey(p => new { p.AdminID, p.ModuleID });

            #endregion

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

            modelBuilder.Entity<Shake_Content>().HasKey(p => new { p.ContentID });

            modelBuilder.Entity<Shake_UserRecord>().HasKey(p => new { p.RecordID });

            #endregion

            #region 短信

            modelBuilder.Entity<System_SMS>().HasKey(p => new { p.Id });

            #endregion

            #region 系统模块接口授权

            modelBuilder.Entity<System_ModuleAuthorize>().HasKey(p => new { p.ServerID, p.ModuleID });

            #endregion

            #region 社区

            modelBuilder.Entity<Circle_Topic>().HasKey(p => p.TopicID);

            modelBuilder.Entity<Circle_Respond>().HasKey(p => p.RespondID);

            modelBuilder.Entity<Circle_PostTrend>().HasKey(p => p.TrendsID);

            modelBuilder.Entity<Circle_Post>().HasKey(p => p.PostID);

            modelBuilder.Entity<Circle_Location>().HasKey(p => p.LocationID);

            modelBuilder.Entity<Circle_Level>().HasKey(p => p.LevelID);

            modelBuilder.Entity<Circle_Good>().HasKey(p => p.GoodID);

            modelBuilder.Entity<Circle_Forum>().HasKey(p => p.ForumID);

            modelBuilder.Entity<Circle_Follow>().HasKey(p => new { p.ForumID, p.UserID });

            modelBuilder.Entity<Circle_EventUser>().HasKey(p => p.EventUserId);

            modelBuilder.Entity<Circle_Event>().HasKey(p => p.EventID);

            modelBuilder.Entity<Circle_CheckIn>().HasKey(p => p.CheckID);

            modelBuilder.Entity<Circle_Category>().HasKey(p => p.CategoryID);

            modelBuilder.Entity<Circle_AttachmentUsage>().HasKey(p => new { p.AttachmentID, p.PostID });

            modelBuilder.Entity<Circle_Attachment>().HasKey(p => p.AttachmentID);

            #endregion

            #region 自营商城

            modelBuilder.Entity<Mall_Category>().HasKey(p => p.CategoryID);

            modelBuilder.Entity<Mall_CategoryTag>().HasKey(p => p.TagID);

            modelBuilder.Entity<Mall_Evaluate>().HasKey(p => p.EvaluateID);

            modelBuilder.Entity<Mall_EvaluateStatistic>().HasKey(p => new { p.ProductID, p.EvaluateLevel });

            modelBuilder.Entity<Mall_Order>().HasKey(p => p.OrderID);

            modelBuilder.Entity<Mall_OrderProductSnapshot>().HasKey(p => p.SnapshotID);

            modelBuilder.Entity<Mall_Product>().HasKey(p => p.ProductID);

            modelBuilder.Entity<Mall_ProductSKU>().HasKey(p => p.SkuID);

            modelBuilder.Entity<Mall_Promotion>().HasKey(p => p.PromotionID);

            modelBuilder.Entity<Mall_PromotionConfig>().HasKey(p => p.ConfigID);

            modelBuilder.Entity<Mall_PromotionProductRelevance>().HasKey(p => new { p.PromotionID, p.ProductID });

            modelBuilder.Entity<Mall_ShoppingCart>().HasKey(p => p.CartID);

            #endregion

            #region 投诉/举报

            modelBuilder.Entity<Complaint>().HasKey(p => p.ComplaintsID);

            #endregion
        }
    }
}
