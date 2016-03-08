using Microsoft.Data.Entity;
using Td.Kylin.Entity;

namespace Td.Kylin.DBCodeFirst
{
    public partial class DataContext
    {
        #region 广告

        /// <summary>
        /// 广告页
        /// </summary>
        public DbSet<Ad_Page> Ad_Page { get { return Set<Ad_Page>(); } }

        /// <summary>
        /// 广告位
        /// </summary>
        public DbSet<Ad_Position> Ad_Position { get { return Set<Ad_Position>(); } }

        /// <summary>
        /// 广告内容
        /// </summary>
        public DbSet<Ad_Content> Ad_Content { get { return Set<Ad_Content>(); } }

        #endregion

        #region 管理员

        /// <summary>
        /// 管理员账户
        /// </summary>
        public DbSet<Admin_Account> Admin_Account { get { return Set<Admin_Account>(); } }

        /// <summary>
        /// 管理员权限
        /// 
        /// </summary>
        public DbSet<Admin_Permission> Admin_Permission { get { return Set<Admin_Permission>(); } }

        #endregion

        #region 商家

        /// <summary>
        /// 商家所属行业
        /// </summary>
        public DbSet<Merchant_Industry> Merchant_Industry { get { return Set<Merchant_Industry>(); } }

        /// <summary>
        /// 商家账户信息
        /// </summary>
        public DbSet<Merchant_Account> Merchant_Account { get { return Set<Merchant_Account>(); } }

        /// <summary>
        /// 商家认证
        /// </summary>
        public DbSet<Merchant_Certificate> Merchant_Certificate { get { return Set<Merchant_Certificate>(); } }

        /// <summary>
        /// 商家业务
        /// </summary>
        public DbSet<Merchant_Business> Merchant_Business { get { return Set<Merchant_Business>(); } }

        /// <summary>
        /// 商家交易记录
        /// </summary>
        public DbSet<Merchant_TradeRecords> Merchant_TradeRecords { get { return Set<Merchant_TradeRecords>(); } }

        /// <summary>
        /// 商家消息
        /// </summary>
        public DbSet<Merchant_Message> Merchant_Message { get { return Set<Merchant_Message>(); } }
        /// <summary>
        /// 商家配置
        /// </summary>
        public DbSet<Merchant_Config> Merchant_Config { get { return Set<Merchant_Config>(); } }

        #endregion

        #region 用户

        /// <summary>
        /// 用户账户信息
        /// </summary>
        public DbSet<User_Account> User_Account { get { return Set<User_Account>(); } }

        /// <summary>
        /// 用户地址库
        /// </summary>
        public DbSet<User_Address> User_Address { get { return Set<User_Address>(); } }

        /// <summary>
        /// 用户使用设备
        /// </summary>
        public DbSet<User_Device> User_Device { get { return Set<User_Device>(); } }

        /// <summary>
        /// 用户社区信息
        /// </summary>
        public DbSet<User_Forum> User_Forum { get { return Set<User_Forum>(); } }

        /// <summary>
        /// 用户位置轨迹
        /// </summary>
        public DbSet<User_LocationTrack> User_LocationTrack { get { return Set<User_LocationTrack>(); } }

        /// <summary>
        /// 用户在线数据
        /// </summary>
        public DbSet<User_Online> User_Online { get { return Set<User_Online>(); } }

        /// <summary>
        /// 用户附属资料
        /// </summary>
        public DbSet<User_Profiles> User_Profiles { get { return Set<User_Profiles>(); } }

        /// <summary>
        /// 用户摇一摇记录
        /// </summary>
        public DbSet<User_ShakeRecord> User_ShakeRecord { get { return Set<User_ShakeRecord>(); } }

        /// <summary>
        /// 用户交易记录
        /// </summary>
        public DbSet<User_TradeRecords> User_TradeRecords { get { return Set<User_TradeRecords>(); } }

        /// <summary>
        /// 用户简历
        /// </summary>
        public DbSet<User_Resume> User_Resume { get { return Set<User_Resume>(); } }

        /// <summary>
        /// 用户福利
        /// </summary>
        public DbSet<User_Welfare> User_Welfare { get { return Set<User_Welfare>(); } }

        /// <summary>
        /// 用户消息
        /// </summary>
        public DbSet<User_Message> User_Message { get { return Set<User_Message>(); } }

        #endregion

        #region 摇一摇

        /// <summary>
        /// 摇一摇数据内容
        /// </summary>
        public DbSet<Shake_Content> Shake_Content { get { return Set<Shake_Content>(); } }

        /// <summary>
        /// 摇一摇记录
        /// </summary>
        public DbSet<Shake_UserRecord> Shake_UserRecord { get { return Set<Shake_UserRecord>(); } }

        #endregion

        #region 短信

        /// <summary>
        /// 系统短信
        /// </summary>
        public DbSet<System_SMS> System_SMS { get { return Set<System_SMS>(); } }

        #endregion

        #region 模块授权

        /// <summary>
        /// 模块授权
        /// </summary>
        public DbSet<System_ModuleAuthorize> System_ModuleAuthorize { get { return Set<System_ModuleAuthorize>(); } }

        #endregion

        #region 社区

        /// <summary>
        /// 帖子主题
        /// </summary>
        public DbSet<Circle_Topic> Circle_Topic { get { return Set<Circle_Topic>(); } }

        /// <summary>
        /// 评论回复（帖中帖）
        /// </summary>
        public DbSet<Circle_Respond> Circle_Respond { get { return Set<Circle_Respond>(); } }

        // <summary>
        /// 回复记录
        /// </summary>
        public DbSet<Circle_PostTrend> Circle_PostTrend { get { return Set<Circle_PostTrend>(); } }

        /// <summary>
        /// 帖子评论
        /// </summary>
        public DbSet<Circle_Post> Circle_Post { get { return Set<Circle_Post>(); } }

        /// <summary>
        /// 帖子及评论位置
        /// </summary>
        public DbSet<Circle_Location> Circle_Location { get { return Set<Circle_Location>(); } }

        /// <summary>
        /// 社区用户等级规则
        /// </summary>
        public DbSet<Circle_Level> Circle_Level { get { return Set<Circle_Level>(); } }

        /// <summary>
        /// 社区商品帖信息
        /// </summary>
        public DbSet<Circle_Good> Circle_Good { get { return Set<Circle_Good>(); } }

        /// <summary>
        /// 社区圈子
        /// </summary>
        public DbSet<Circle_Forum> Circle_Forum { get { return Set<Circle_Forum>(); } }

        /// <summary>
        /// 社区圈子关注
        /// </summary>
        public DbSet<Circle_Follow> Circle_Follow { get { return Set<Circle_Follow>(); } }

        /// <summary>
        /// 社区圈子活动报名用户
        /// </summary>
        public DbSet<Circle_EventUser> Circle_EventUser { get { return Set<Circle_EventUser>(); } }

        /// <summary>
        /// 社区活动帖信息
        /// </summary>
        public DbSet<Circle_Event> Circle_Event { get { return Set<Circle_Event>(); } }

        /// <summary>
        /// 社区签到记录
        /// </summary>
        public DbSet<Circle_CheckIn> Circle_CheckIn { get { return Set<Circle_CheckIn>(); } }

        /// <summary>
        /// 圈子分类
        /// </summary>
        public DbSet<Circle_Category> Circle_Category { get { return Set<Circle_Category>(); } }

        /// <summary>
        /// 附件帖子关联
        /// </summary>
        public DbSet<Circle_AttachmentUsage> Circle_AttachmentUsage { get { return Set<Circle_AttachmentUsage>(); } }

        /// <summary>
        /// 附件
        /// </summary>
        public DbSet<Circle_Attachment> Circle_Attachment { get { return Set<Circle_Attachment>(); } }

        #endregion

        #region 自营商城

        /// <summary>
        /// 商品分类
        /// </summary>
        public DbSet<Mall_Category> Mall_Category { get { return Set<Mall_Category>(); } }

        /// <summary>
        /// 商品分类标签
        /// </summary>
        public DbSet<Mall_CategoryTag> Mall_CategoryTag { get { return Set<Mall_CategoryTag>(); } }

        /// <summary>
        /// 订单商品评价
        /// </summary>
        public DbSet<Mall_Evaluate> Mall_Evaluate { get { return Set<Mall_Evaluate>(); } }

        /// <summary>
        /// 商品评价统计
        /// </summary>
        public DbSet<Mall_EvaluateStatistics> Mall_EvaluateStatistics { get { return Set<Mall_EvaluateStatistics>(); } }

        /// <summary>
        /// 订单
        /// </summary>
        public DbSet<Mall_Order> Mall_Order { get { return Set<Mall_Order>(); } }

        /// <summary>
        /// 订单商品快照
        /// </summary>
        public DbSet<Mall_OrderProductSnapshot> Mall_OrderProductSnapshot { get { return Set<Mall_OrderProductSnapshot>(); } }

        /// <summary>
        /// 商品
        /// </summary>
        public DbSet<Mall_Product> Mall_Product { get { return Set<Mall_Product>(); } }

        /// <summary>
        /// 商品SKU
        /// </summary>
        public DbSet<Mall_ProductSKU> Mall_ProductSKU { get { return Set<Mall_ProductSKU>(); } }

        /// <summary>
        /// 促销
        /// </summary>
        public DbSet<Mall_Promotion> Mall_Promotion { get { return Set<Mall_Promotion>(); } }

        /// <summary>
        /// 促销规则
        /// </summary>
        public DbSet<Mall_PromotionConfig> Mall_PromotionConfig { get { return Set<Mall_PromotionConfig>(); } }

        /// <summary>
        /// 促销商品关联
        /// </summary>
        public DbSet<Mall_PromotionProductRelevance> Mall_PromotionProductRelevance { get { return Set<Mall_PromotionProductRelevance>(); } }

        /// <summary>
        /// 购物车
        /// </summary>
        public DbSet<Mall_ShoppingCart> Mall_ShoppingCart { get { return Set<Mall_ShoppingCart>(); } }

        #endregion

        #region 投诉/举报

        /// <summary>
        /// 投诉/举报
        /// </summary>
        public DbSet<Complaint> Complaint { get { return Set<Complaint>(); } }

        #endregion

        #region 限时福利

        /// <summary>
        /// 商家福利
        /// </summary>
        public DbSet<Merchant_Welfare> Merchant_Welfare { get { return Set<Merchant_Welfare>(); } }

        /// <summary>
        /// 优惠券福利信息
        /// </summary>
        public DbSet<Welfare_Coupon> Welfare_Coupon { get { return Set<Welfare_Coupon>(); } }

        /// <summary>
        /// 折扣商品福利信息
        /// </summary>
        public DbSet<Welfare_Goods> Welfare_Goods { get { return Set<Welfare_Goods>(); } }

        /// <summary>
        /// 赠送商品福利信息
        /// </summary>
        public DbSet<Welfare_DonatedGoods> Welfare_DonatedGoods { get { return Set<Welfare_DonatedGoods>(); } }

        /// <summary>
        /// 福利分期
        /// </summary>
        public DbSet<Welfare_Phases> Welfare_Phases { get { return Set<Welfare_Phases>(); } }

        /// <summary>
        /// 福利参与人员
        /// </summary>
        public DbSet<Welfare_PartUser> Welfare_PartUser { get { return Set<Welfare_PartUser>(); } }

        /// <summary>
        /// 福利开放参与前需要提醒的名称
        /// </summary>
        public DbSet<Welfare_Remind> Welfare_Remind { get { return Set<Welfare_Remind>(); } }

        #endregion

        #region 商家商品

        /// <summary>
        /// 商家自定义商品分类
        /// </summary>
        public DbSet<MerchGoods_Category> MerchGoods_Category { get { return Set<MerchGoods_Category>(); } }

        /// <summary>
        /// 商家发布的商品
        /// </summary>
        public DbSet<MerchGoods_Goods> MerchGoods_Goods { get { return Set<MerchGoods_Goods>(); } }

        #endregion

        #region 商家服务

        /// <summary>
        /// 商家发布的服务
        /// </summary>
        public DbSet<MerchService_Goods> MerchService_Goods { get { return Set<MerchService_Goods>(); } }

        #endregion

        #region 平台提供的商家服务业务

        /// <summary>
        /// 平台提供的服务业务
        /// </summary>
        public DbSet<KylinService_Business> KylinService_Business { get { return Set<KylinService_Business>(); } }

        /// <summary>
        /// 平台服务业务子项
        /// </summary>
        public DbSet<KylinService_BusinessOptions> KylinService_BusinessOptions { get { return Set<KylinService_BusinessOptions>(); } }

        /// <summary>
        /// 平台服务价格配置
        /// </summary>
        public DbSet<KylinService_BusinessConfig> KylinService_BusinessConfig { get { return Set<KylinService_BusinessConfig>(); } }

        #endregion

        #region 上门预约服务订单

        /// <summary>
        /// 服务订单
        /// </summary>
        public DbSet<KylinService_Order> KylinService_Order { get { return Set<KylinService_Order>(); } }

        #endregion

        #region 招聘

        /// <summary>
        /// 岗位类型
        /// </summary>
        public DbSet<Job_Category> Job_Category { get { return Set<Job_Category>(); } }

        /// <summary>
        /// 招聘信息
        /// </summary>
        public DbSet<Job_Recruitment> Job_Recruitment { get { return Set<Job_Recruitment>(); } }

        /// <summary>
        /// 招聘职位投递/申请
        /// </summary>
        public DbSet<Job_Apply> Job_Apply { get { return Set<Job_Apply>(); } }

        /// <summary>
        /// 职位搜索器
        /// </summary>
        public DbSet<Job_Searcher> Job_Searcher { get { return Set<Job_Searcher>(); } }

        #endregion

        #region 服务职员

        /// <summary>
        /// 服务职员账户
        /// </summary>
        public DbSet<Worker_Account> Worker_Account { get { return Set<Worker_Account>(); } }

        /// <summary>
        /// 服务职员认证信息
        /// </summary>
        public DbSet<Worker_Certification> Worker_Certification { get { return Set<Worker_Certification>(); } }

        /// <summary>
        /// 服务职员业务
        /// </summary>
        public DbSet<Worker_Business> Worker_Business { get { return Set<Worker_Business>(); } }

        /// <summary>
        /// 服务职员所服务的企业（商家）
        /// </summary>
        public DbSet<Worker_Company> Worker_Company { get { return Set<Worker_Company>(); } }

        /// <summary>
        /// 服务职员附属信息
        /// </summary>
        public DbSet<Worker_Profile> Worker_Profile { get { return Set<Worker_Profile>(); } }

        /// <summary>
        /// 服务职员在企业（商家）中的业务关系
        /// </summary>
        public DbSet<Worker_CompanyBusiness> Worker_CompanyBusiness { get { return Set<Worker_CompanyBusiness>(); } }

        /// <summary>
        /// 服务职员交易记录
        /// </summary>
        public DbSet<Worker_TradeRecords> Worker_TradeRecords { get { return Set<Worker_TradeRecords>(); } }

        /// <summary>
        /// 服务人员消息
        /// </summary>
        public DbSet<Worker_Message> Worker_Message { get { return Set<Worker_Message>(); } }

        #endregion

        #region 区域
        /// <summary>
        /// 区域
        /// </summary>
        public DbSet<System_Area> System_Area { get { return Set<System_Area>(); } }
        public DbSet<Area_Open> Area_Open { get { return Set<Area_Open>(); } }
        #endregion

        #region 运营商
        /// <summary>
        /// 运营商
        /// </summary>
        public DbSet<Area_Operator> Area_Operator { get { return Set<Area_Operator>(); } }

        /// <summary>
        /// 运营商附属信息
        /// </summary>
        public DbSet<Area_OperatorProfile> Area_OperatorProfile { get { return Set<Area_OperatorProfile>(); } }

        /// <summary>
        /// 运营商及运营区域关联
        /// </summary>
        public DbSet<Area_OperatorRelation> Area_OperatorRelation { get { return Set<Area_OperatorRelation>(); } }
        #endregion
    }
}
