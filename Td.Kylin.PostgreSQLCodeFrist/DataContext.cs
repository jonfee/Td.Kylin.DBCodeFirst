using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Td.Kylin.Entity;

namespace Td.Kylin.PostgreSQLCodeFirst
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public partial class DataContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = Startup.Configuration["Data:DefaultConnectionString"];
            optionsBuilder.UseNpgsql(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            #endregion

            #region 抽成

            //平台对区域抽成配置
            modelBuilder.Entity<Commission_Platform>(entity =>
            {
                entity.HasKey(p => new { p.AreaID, p.CommissionItem });
            });

            //区域运营商对区域下交易默认抽成配置
            modelBuilder.Entity<Commission_OperatorDefault>(entity =>
            {
                entity.HasKey(p => new { p.AreaID, p.CommissionItem });
            });

            //区域运营商对商家的抽成配置
            modelBuilder.Entity<Commission_OperatorFromMerchant>(entity =>
            {
                entity.HasKey(p => new { p.AreaID, p.MerchantID, p.CommissionItem });
            });

            //区域运营商对个人服务者的抽成配置
            modelBuilder.Entity<Commission_OperatorFromWorker>(entity =>
            {
                entity.HasKey(p => new { p.AreaID, p.UserID, p.CommissionItem });
            });

            #endregion

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

            //平台广告
            modelBuilder.Entity<Ad_PlatformContent>(entity =>
            {
                entity.Property(p => p.ContentID).ValueGeneratedNever();
                entity.HasKey(p => p.ContentID);
            });

            //平台广告推送到区域
            modelBuilder.Entity<Ad_PlatformToArea>(entity =>
            {
                entity.HasKey(p => new { p.ContentID, p.AreaID });
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

            modelBuilder.Entity<MerchantGoods_SystemCategory>(entity =>
            {
                entity.Property(p => p.CategoryID).ValueGeneratedNever();
                entity.HasKey(p => p.CategoryID);
            });

            modelBuilder.Entity<Merchant_Industry>(entity =>
            {
                entity.Property(p => p.IndustryID).ValueGeneratedNever();
                entity.HasKey(p => p.IndustryID);
            });

			modelBuilder.Entity<Merchant_IndustryRecommend>(entity =>
			{
				entity.HasKey(p => new { p.AreaID, p.IndustryID});
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

            modelBuilder.Entity<Merchant_Business>(entity =>
            {
                entity.HasKey(p => new { p.MerchantID, p.BusinessID });
            });

            modelBuilder.Entity<Merchant_TradeRecords>(entity =>
            {
                entity.Property(p => p.TradeID).ValueGeneratedNever();
                entity.HasKey(p => p.TradeID);
            });

            modelBuilder.Entity<Merchant_Message>(entity =>
            {
                entity.Property(p => p.MessageID).ValueGeneratedNever();
                entity.HasKey(p => p.MessageID);
            });
            //商家配置表
            modelBuilder.Entity<Merchant_Config>(entity =>
            {
                entity.Property(p => p.MerchantID).ValueGeneratedNever();
                entity.HasKey(p => p.MerchantID);
            });
            //商家订单表
            modelBuilder.Entity<Merchant_Order>(entity =>
            {
                entity.Property(p => p.OrderID).ValueGeneratedNever();
                entity.HasKey(p => p.OrderID);
            });
            //商家订单快照
            modelBuilder.Entity<Merchant_OrderSnapshot>(entity =>
            {
                entity.Property(p => p.SnapshotID).ValueGeneratedNever();
                entity.HasKey(p => p.SnapshotID);
            });
            //商家商品评论表
            modelBuilder.Entity<Merchant_Evaluate>(entity =>
            {
                entity.Property(p => p.EvaluateID).ValueGeneratedNever();
                entity.HasKey(p => p.EvaluateID);
            });
            //商家商品汇总表
            modelBuilder.Entity<Merchant_EvaluateStatistics>(entity =>
            {
                //entity.Property(p => p.ProductID).ValueGeneratedNever();
                entity.HasKey(p => new { p.ProductID, p.EvaluateLevel });
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

            modelBuilder.Entity<User_Resume>(entity =>
            {
                entity.Property(p => p.ResumeID).ValueGeneratedNever();
                entity.HasKey(p => p.ResumeID);
            });

            modelBuilder.Entity<User_Welfare>(entity =>
            {
                entity.Property(p => p.ConsumerCode).ValueGeneratedNever();
                entity.HasKey(p => p.ConsumerCode);
            });

            modelBuilder.Entity<User_Message>(entity =>
            {
                entity.Property(p => p.MessageID).ValueGeneratedNever();
                entity.HasKey(p => p.MessageID);
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
                entity.HasKey(p => new { p.AreaForumID, p.UserID });
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

            modelBuilder.Entity<Circle_AreaForum>(entity =>
            {
                entity.Property(p => p.AreaForumID).ValueGeneratedNever();
                entity.HasKey(p => p.AreaForumID);
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

            modelBuilder.Entity<Mall_EvaluateStatistics>(entity =>
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

            modelBuilder.Entity<Welfare_Phases>(entity =>
            {
                entity.Property(p => p.PhasesID).ValueGeneratedNever();
                entity.HasKey(p => p.PhasesID);
            });

            modelBuilder.Entity<Welfare_PartUser>(entity =>
            {
                entity.HasKey(p => new { p.PhasesID, p.UserID });
            });

            modelBuilder.Entity<Welfare_Remind>(entity =>
            {
                entity.HasKey(p => new { p.PhasesID, p.UserID });
            });

            #endregion

            #region 商家商品

            modelBuilder.Entity<MerchGoods_Category>(entity =>
            {
                entity.Property(p => p.CategoryID).ValueGeneratedNever();
                entity.HasKey(p => p.CategoryID);
            });

            modelBuilder.Entity<MerchGoods_Goods>(entity =>
            {
                entity.Property(p => p.GoodsID).ValueGeneratedNever();
                entity.HasKey(p => p.GoodsID);
            });

            #endregion

            #region 商家服务

            modelBuilder.Entity<MerchService_Goods>(entity =>
            {
                entity.Property(p => p.ServiceGoodsID).ValueGeneratedNever();
                entity.HasKey(p => p.ServiceGoodsID);

            });

            #endregion

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

            #region 上门预约服务订单

            modelBuilder.Entity<KylinService_Order>(entity =>
           {
               entity.Property(p => p.OrderID).ValueGeneratedNever();
               entity.HasKey(p => p.OrderID);
           });

            #endregion

            #region 招聘

            modelBuilder.Entity<Job_Category>(entity =>
            {
                entity.Property(p => p.CategoryID).ValueGeneratedNever();
                entity.HasKey(p => p.CategoryID);
            });

            modelBuilder.Entity<Job_Recruitment>(entity =>
            {
                entity.Property(p => p.RecruitmentID).ValueGeneratedNever();
                entity.HasKey(p => p.RecruitmentID);
            });

            modelBuilder.Entity<Job_Apply>(entity =>
            {
                entity.HasKey(p => new { p.RecruitmentID, p.ResumeID });
            });

            modelBuilder.Entity<Job_Searcher>(entity =>
            {
                entity.Property(p => p.SearcherID).ValueGeneratedNever();
                entity.HasKey(p => p.SearcherID);
            });

            #endregion

            #region 服务职员

            modelBuilder.Entity<Worker_Account>(entity =>
           {
               entity.Property(p => p.WorkerID).ValueGeneratedNever();
               entity.HasKey(p => p.WorkerID);
           });

            modelBuilder.Entity<User_Certification>(entity =>
            {
                entity.Property(p => p.CertificateID).ValueGeneratedNever();
                entity.HasKey(p => p.CertificateID);
            });

            modelBuilder.Entity<Worker_Business>(entity =>
            {
                entity.HasKey(p => new { p.UserID, p.BusinessID });
            });

            modelBuilder.Entity<Worker_Company>(entity =>
            {
                entity.HasKey(p => new { p.UserID, p.MerchantID });
            });

            modelBuilder.Entity<Worker_Profile>(entity =>
            {
                entity.Property(p => p.UserID).ValueGeneratedNever();
                entity.HasKey(p => p.UserID);
            });

            modelBuilder.Entity<Worker_CompanyBusiness>(entity =>
            {
                entity.HasKey(p => new { p.UserID, p.MerchantID, p.BusinessID });
            });

            modelBuilder.Entity<Worker_Message>(entity =>
            {
                entity.Property(p => p.MessageID).ValueGeneratedNever();
                entity.HasKey(p => p.MessageID);
            });

            modelBuilder.Entity<Worker_TradeRecords>(entity =>
            {
                entity.Property(p => p.TradeID).ValueGeneratedNever();
                entity.HasKey(p => p.TradeID);
            });

            #endregion

            #region 区域
            modelBuilder.Entity<System_Area>(entity =>
            {
                entity.Property(p => p.AreaID).ValueGeneratedNever();
                entity.HasKey(p => p.AreaID);
            });
            modelBuilder.Entity<Area_Open>(entity =>
            {
                entity.Property(p => p.AreaID).ValueGeneratedNever();
                entity.HasKey(p => p.AreaID);
            });
            modelBuilder.Entity<Area_RecommendIndustry>(entity =>
            {
                entity.HasKey(p => new { p.AreaID, p.IndustryID });
            });
            #endregion

            #region 运营商
            //运营商
            modelBuilder.Entity<Area_Operator>(entity =>
            {
                entity.Property(p => p.OperatorID).ValueGeneratedNever();
                entity.HasKey(p => p.OperatorID);
            });
            //运营商附属信息
            modelBuilder.Entity<Area_OperatorProfile>(entity =>
            {
                entity.Property(p => p.OperatorID).ValueGeneratedNever();
                entity.HasKey(p => p.OperatorID);
            });
            //运营商及运营的区域关联
            modelBuilder.Entity<Area_OperatorRelation>(entity =>
            {
                entity.HasKey(p => new { p.OperatorID, p.AreaID });
            });

            #endregion

            #region 代理商

            //代理商
            modelBuilder.Entity<Agent_Account>(entity =>
            {
                entity.Property(p => p.AgentID).ValueGeneratedNever();
                entity.HasKey(p => p.AgentID);
            });

            //代理商附属信息
            modelBuilder.Entity<Agent_Profile>(entity =>
            {
                entity.Property(p => p.AgentID).ValueGeneratedNever();
                entity.HasKey(p => p.AgentID);
            });

            //代理商代理区域关联
            modelBuilder.Entity<Agent_AreaRelation>(entity =>
            {
                entity.HasKey(p => new { p.AgentID, p.AgentAreaID });
            });

            #endregion

            #region 淘一淘及购物车

            modelBuilder.Entity<Mall_ShoppingCart>(entity =>
            {
                entity.Property(p => p.CartID).ValueGeneratedNever();
                entity.HasKey(p => p.CartID);
            });

            modelBuilder.Entity<Tao_ProductRecommend>(entity =>
            {
                entity.Property(p => p.RecommendID).ValueGeneratedNever();
                entity.HasKey(p => p.RecommendID);
            });

            #endregion
        }
    }
}
