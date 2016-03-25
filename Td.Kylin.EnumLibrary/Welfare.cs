namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 限时福利类型
    /// </summary>
    public enum WelfareType
    {
        /// <summary>
        /// 优惠券
        /// </summary>
        Coupon = 1,
        /// <summary>
        /// 免费商品
        /// </summary>
        FreeGoods = 2,
        /// <summary>
        /// 折扣商品
        /// </summary>
        DiscountGoods = 4
    }

    /// <summary>
    /// 优惠券福利使用方式
    /// </summary>
    public enum WelfareCouponUsage
    {
        /// <summary>
        /// 到店使用
        /// </summary>
        AtStoreUse = 1,
        /// <summary>
        /// 线上使用
        /// </summary>
        OnLineUse = 2
    }

    /// <summary>
    /// 商品福利领取方式
    /// </summary>
    public enum WelfareGoodsGetType
    {
        /// <summary>
        /// 到店领取
        /// </summary>
        AtStoreUse = 1
    }

    /// <summary>
    /// 限时福利状态
    /// </summary>
    public enum WelfareStatus
    {
        /// <summary>
        /// 审核中
        /// </summary>
        Auditing = 1,
        /// <summary>
        /// 审核失败
        /// </summary>
        AuditFailure = 2,
        /// <summary>
        /// 未排期（已审核通过，但未安排发放时间）
        /// </summary>
        NotScheduling = 4,
        /// <summary>
        /// 进行中（已安排发放）
        /// </summary>
        InProgress = 8,
        /// <summary>
        /// 已完成（所有福利排期均已完成）
        /// </summary>
        Done = 16,
        /// <summary>
        /// 已关闭（人为关闭福利）
        /// </summary>
        Closed = 32
    }
}
