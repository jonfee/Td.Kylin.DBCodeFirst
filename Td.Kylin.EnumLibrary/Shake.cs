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
        Auditing=1,
        /// <summary>
        /// 审核成功
        /// </summary>
        Success=2,
        /// <summary>
        /// 审核失败
        /// </summary>
        Failure=4
    }

    /// <summary>
    /// 摇一摇类型
    /// </summary>
    public enum ShakeType
    {
        /// <summary>
        /// 社区
        /// </summary>
        Circle = 1,
        /// <summary>
        /// 商品
        /// </summary>
        Product = 2,
        /// <summary>
        /// 企业
        /// </summary>
        Company = 3,
        /// <summary>
        /// 招聘
        /// </summary>
        Job = 4,
        /// <summary>
        /// 活动
        /// </summary>
        Event = 5,
        /// <summary>
        /// 推广
        /// </summary>
        Spread = 6,
        /// <summary>
        /// 其它
        /// </summary>
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
        TopicHuaTi = 1,
        /// <summary>
        /// 社区活动帖
        /// </summary>
        TopicEvent = 2,
        /// <summary>
        /// 社区商品帖
        /// </summary>
        TopicGoods = 3,
        /// <summary>
        /// B2C商品
        /// </summary>
        B2CProduct = 4,
        /// <summary>
        /// 限时福利
        /// </summary>
        Welfare = 5,
        /// <summary>
        /// 招聘信息
        /// </summary>
        Job = 6,
        /// <summary>
        /// 企业
        /// </summary>
        Company = 7,
        /// <summary>
        /// 商家商品
        /// </summary>
        MerchantProduct = 8,
        /// <summary>
        /// 平台现金红包
        /// </summary>
        PlatformRedEnvelope = 9,
        /// <summary>
        /// 广告
        /// </summary>
        AD = 10
    }
}
