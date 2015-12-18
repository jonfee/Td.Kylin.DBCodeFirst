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

            /// <summary>
            /// 广告内容
            /// </summary>
            modelBuilder.Entity<Ad_Content>(entity =>
            {
                entity.Property(p => p.ContentID).ValueGeneratedNever();
                entity.HasKey(p => p.ContentID);
            });

            #endregion

            #region 管理员

            /// <summary>
            /// 管理员账户
            /// </summary>
            modelBuilder.Entity<Admin_Account>(entity =>
            {
                entity.Property(p => p.AdminID).ValueGeneratedNever();
                entity.HasKey(p => p.AdminID);
            });

            /// <summary>
            /// 管理员权限
            /// </summary>
            modelBuilder.Entity<Admin_Permission>(entity =>
            {
                entity.HasKey(p => new { p.AdminID, p.ModuleID });
            });

            #endregion

            #region 商家

            modelBuilder.Entity<Merchant_Industry>(entity =>
            {
                entity.Property(p => p.IndustryID).ValueGeneratedNever();
                entity.HasKey(p => p.IndustryID);
            });

            modelBuilder.Entity<Merchant_Account>(entity =>
            {
                entity.Property(p => p.MerchantID).ValueGeneratedNever();
                entity.HasKey(p => p.MerchantID);
            });

            modelBuilder.Entity<Merchant_Certificate>(entity =>
            {
                entity.Property(p => p.CertificateID).ValueGeneratedNever();
                entity.HasKey(p => p.CertificateID);
            });

            #endregion

            #region 用户

            modelBuilder.Entity<User_Account>(entity =>
            {
                entity.Property(p => p.UserID).ValueGeneratedNever();
                entity.HasKey(p => p.UserID);
            });

            modelBuilder.Entity<User_Address>(entity =>
            {
                entity.Property(p => p.AddressID).ValueGeneratedNever();
                entity.HasKey(p => p.AddressID);
            });

            modelBuilder.Entity<User_Device>(entity =>
            {
                entity.Property(p => p.DeviceID).ValueGeneratedNever();
                entity.HasKey(p => p.DeviceID);
            });

            modelBuilder.Entity<User_Forum>(entity =>
            {
                entity.Property(p => p.UserID).ValueGeneratedNever();
                entity.HasKey(p => p.UserID);
            });

            modelBuilder.Entity<User_LocationTrack>(entity =>
            {
                entity.Property(p => p.TrackID).ValueGeneratedNever();
                entity.HasKey(p => p.TrackID);
            });

            modelBuilder.Entity<User_Online>(entity =>
            {
                entity.Property(p => p.UserID).ValueGeneratedNever();
                entity.HasKey(p => p.UserID);
            });

            modelBuilder.Entity<User_Profiles>(entity =>
            {
                entity.Property(p => p.UserID).ValueGeneratedNever();
                entity.HasKey(p => p.UserID);
            });

            modelBuilder.Entity<User_ShakeRecord>(entity =>
            {
                entity.Property(p => p.UserID).ValueGeneratedNever();
                entity.HasKey(p => p.UserID);
            });

            modelBuilder.Entity<User_TradeRecords>(entity =>
            {
                entity.Property(p => p.TradeID).ValueGeneratedNever();
                entity.HasKey(p => p.TradeID);
            });

            #endregion

            #region 摇一摇

            modelBuilder.Entity<Shake_Content>(entity =>
            {
                entity.Property(p => p.ContentID).ValueGeneratedNever();
                entity.HasKey(p => p.ContentID);
            });

            modelBuilder.Entity<Shake_UserRecord>(entity =>
            {
                entity.Property(p => p.RecordID).ValueGeneratedNever();
                entity.HasKey(p => p.RecordID);
            });

            #endregion

            #region 短信

            modelBuilder.Entity<System_SMS>(entity =>
            {
                entity.Property(p => p.Id).ValueGeneratedNever();
                entity.HasKey(p => p.Id);
            });

            #endregion

            #region 系统模块接口授权

            modelBuilder.Entity<System_ModuleAuthorize>(entity =>
            {
                entity.HasKey(p => new { p.ServerID, p.ModuleID });
            });

            #endregion

            #region 社区

            modelBuilder.Entity<Circle_Topic>(entity =>
            {
                entity.Property(p => p.TopicID).ValueGeneratedNever();
                entity.HasKey(p => p.TopicID);
            });

            modelBuilder.Entity<Circle_Respond>(entity =>
            {
                entity.Property(p => p.RespondID).ValueGeneratedNever();
                entity.HasKey(p => p.RespondID);
            });

            modelBuilder.Entity<Circle_PostTrend>(entity =>
            {
                entity.Property(p => p.TrendsID).ValueGeneratedNever();
                entity.HasKey(p => p.TrendsID);
            });

            modelBuilder.Entity<Circle_Post>(entity =>
            {
                entity.Property(p => p.PostID).ValueGeneratedNever();
                entity.HasKey(p => p.PostID);
            });

            modelBuilder.Entity<Circle_Location>(entity =>
            {
                entity.Property(p => p.LocationID).ValueGeneratedNever();
                entity.HasKey(p => p.LocationID);
            });

            modelBuilder.Entity<Circle_Level>(entity =>
            {
                entity.Property(p => p.LevelID).ValueGeneratedNever();
                entity.HasKey(p => p.LevelID);
            });

            modelBuilder.Entity<Circle_Good>(entity =>
            {
                entity.Property(p => p.GoodID).ValueGeneratedNever();
                entity.HasKey(p => p.GoodID);
            });

            modelBuilder.Entity<Circle_Forum>(entity =>
            {
                entity.Property(p => p.ForumID).ValueGeneratedNever();
                entity.HasKey(p => p.ForumID);
            });

            modelBuilder.Entity<Circle_Follow>(entity =>
            {
                entity.HasKey(p => new { p.ForumID, p.UserID });
            });

            modelBuilder.Entity<Circle_EventUser>(entity =>
            {
                entity.Property(p => p.EventUserId).ValueGeneratedNever();
                entity.HasKey(p => p.EventUserId);
            });

            modelBuilder.Entity<Circle_Event>(entity =>
            {
                entity.Property(p => p.EventID).ValueGeneratedNever();
                entity.HasKey(p => p.EventID);
            });

            modelBuilder.Entity<Circle_CheckIn>(entity =>
            {
                entity.Property(p => p.CheckID).ValueGeneratedNever();
                entity.HasKey(p => p.CheckID);
            });

            modelBuilder.Entity<Circle_Category>(entity =>
            {
                entity.Property(p => p.CategoryID).ValueGeneratedNever();
                entity.HasKey(p => p.CategoryID);
            });

            modelBuilder.Entity<Circle_AttachmentUsage>(entity =>
            {
                entity.HasKey(p => new { p.AttachmentID, p.PostID });
            });

            modelBuilder.Entity<Circle_Attachment>(entity =>
            {
                entity.Property(p => p.AttachmentID).ValueGeneratedNever();
                entity.HasKey(p => p.AttachmentID);
            });

            #endregion

            #region 自营商城

            modelBuilder.Entity<Mall_Category>(entity =>
            {
                entity.Property(p => p.CategoryID).ValueGeneratedNever();
                entity.HasKey(p => p.CategoryID);
            });

            modelBuilder.Entity<Mall_CategoryTag>(entity =>
            {
                entity.Property(p => p.TagID).ValueGeneratedNever();
                entity.HasKey(p => p.TagID);
            });

            modelBuilder.Entity<Mall_Evaluate>(entity =>
            {
                entity.Property(p => p.EvaluateID).ValueGeneratedNever();
                entity.HasKey(p => p.EvaluateID);
            });

            modelBuilder.Entity<Mall_EvaluateStatistic>(entity =>
            {
                entity.HasKey(p => new { p.ProductID, p.EvaluateLevel });
            });

            modelBuilder.Entity<Mall_Order>(entity =>
            {
                entity.Property(p => p.OrderID).ValueGeneratedNever();
                entity.HasKey(p => p.OrderID);
            });

            modelBuilder.Entity<Mall_OrderProductSnapshot>(entity =>
            {
                entity.Property(p => p.SnapshotID).ValueGeneratedNever();
                entity.HasKey(p => p.SnapshotID);
            });

            modelBuilder.Entity<Mall_Product>(entity =>
            {
                entity.Property(p => p.ProductID).ValueGeneratedNever();
                entity.HasKey(p => p.ProductID);
            });

            modelBuilder.Entity<Mall_ProductSKU>(entity =>
            {
                entity.Property(p => p.SkuID).ValueGeneratedNever();
                entity.HasKey(p => p.SkuID);
            });

            modelBuilder.Entity<Mall_Promotion>(entity =>
            {
                entity.Property(p => p.PromotionID).ValueGeneratedNever();
                entity.HasKey(p => p.PromotionID);
            });

            modelBuilder.Entity<Mall_PromotionConfig>(entity =>
            {
                entity.Property(p => p.ConfigID).ValueGeneratedNever();
                entity.HasKey(p => p.ConfigID);
            });

            modelBuilder.Entity<Mall_PromotionProductRelevance>(entity =>
            {
                entity.HasKey(p => new { p.PromotionID, p.ProductID });
            });

            modelBuilder.Entity<Mall_ShoppingCart>(entity =>
            {
                entity.Property(p => p.CartID).ValueGeneratedNever();
                entity.HasKey(p => p.CartID);
            });

            #endregion

            #region 投诉/举报

            modelBuilder.Entity<Complaint>(entity =>
            {
                entity.Property(p => p.ComplaintsID).ValueGeneratedNever();
                entity.HasKey(p => p.ComplaintsID);
            });

            #endregion

            #region 限时福利

            modelBuilder.Entity<Merchant_Welfare>(entity =>
            {
                entity.Property(p => p.WelfareID).ValueGeneratedNever();
                entity.HasKey(p => p.WelfareID);
            });

            modelBuilder.Entity<Welfare_Coupon>(entity =>
            {
                entity.Property(p => p.WelfareID).ValueGeneratedNever();
                entity.HasKey(p => p.WelfareID);
            });

            modelBuilder.Entity<Welfare_Goods>(entity =>
            {
                entity.Property(p => p.WelfareID).ValueGeneratedNever();
                entity.HasKey(p => p.WelfareID);
            });

            modelBuilder.Entity<Welfare_DonatedGoods>(entity =>
            {
                entity.Property(p => p.WelfareID).ValueGeneratedNever();
                entity.HasKey(p => p.WelfareID);
            });

            modelBuilder.Entity<Welfare_Stage>(entity =>
            {
                entity.Property(p => p.StageID).ValueGeneratedNever();
                entity.HasKey(p => p.StageID);
            });

            modelBuilder.Entity<Welfare_PartUser>(entity =>
            {
                entity.HasKey(p => new { p.StageID, p.UserID });
            });

            #endregion
        }
    }
}
