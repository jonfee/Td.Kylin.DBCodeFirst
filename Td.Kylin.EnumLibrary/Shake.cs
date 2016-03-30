

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 摇一摇审核状态
    /// </summary>
    public enum ShakeAuditStatus
    {
        /// <summary>
        /// 审核中
        /// </summary>
        [Description("审核中")]
        Auditing = 1,
        /// <summary>
        /// 审核成功
        /// </summary>
        [Description("审核成功")]
        Success = 2,
        /// <summary>
        /// 审核失败
        /// </summary>
        [Description("审核失败")]
        Failure = 4
    }

    /// <summary>
    /// 摇一摇类型
    /// </summary>
    public enum ShakeType
    {
        /// <summary>
        /// 社区
        /// </summary>
        [Description("社区")]
        Circle = 1,
        /// <summary>
        /// 商品
        /// </summary>
        [Description("商品")]
        Product = 2,
        /// <summary>
        /// 企业
        /// </summary>
        [Description("企业")]
        Company = 3,
        /// <summary>
        /// 招聘
        /// </summary>
        [Description("招聘")]
        Job = 4,
        /// <summary>
        /// 活动
        /// </summary>
        [Description("活动")]
        Event = 5,
        /// <summary>
        /// 推广
        /// </summary>
        [Description("活动")]
        Spread = 6,
        /// <summary>
        /// 其它
        /// </summary>
        [Description("其它")]
        Other = 7
    }

    /// <summary>
    /// 摇一摇数据类型
    /// </summary>
    public enum ShakeDataType
    {
        /// <summary>
        /// 社区话题帖
        /// </summary>
        [Description("社区话题帖")]
        TopicHuaTi = 1,
        /// <summary>
        /// 社区活动帖
        /// </summary>
        [Description("社区活动帖")]
        TopicEvent = 2,
        /// <summary>
        /// 社区商品帖
        /// </summary>
        [Description("社区商品帖")]
        TopicGoods = 3,
        /// <summary>
        /// B2C商品
        /// </summary>
        [Description("B2C商品")]
        B2CProduct = 4,
        /// <summary>
        /// 限时福利
        /// </summary>
        [Description("限时福利")]
        Welfare = 5,
        /// <summary>
        /// 招聘信息
        /// </summary>
        [Description("招聘信息")]
        Job = 6,
        /// <summary>
        /// 企业
        /// </summary>
        [Description("企业")]
        Company = 7,
        /// <summary>
        /// 商家商品
        /// </summary>
        [Description("商家商品")]
        MerchantProduct = 8,
        /// <summary>
        /// 平台现金红包
        /// </summary>
        [Description("平台现金红包")]
        PlatformRedEnvelope = 9,
        /// <summary>
        /// 广告
        /// </summary>
        [Description("广告")]
        AD = 10
    }
}
