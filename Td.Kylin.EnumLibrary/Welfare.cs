using Td.ComponentModel;

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
        [Description("优惠券")]
        Coupon = 1,
        /// <summary>
        /// 免费商品
        /// </summary>
        [Description("免费商品")]
        FreeGoods = 2,
        /// <summary>
        /// 折扣商品
        /// </summary>
        [Description("折扣商品")]
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
        [Description("到店使用")]
        AtStoreUse = 1,
        /// <summary>
        /// 线上使用
        /// </summary>
        [Description("线上使用")]
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
        [Description("到店领取")]
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
        [Description("审核中")]
        Auditing = 1,
        /// <summary>
        /// 审核失败
        /// </summary>
        [Description("审核失败")]
        AuditFailure = 2,
        /// <summary>
        /// 未排期（已审核通过，但未安排发放时间）
        /// </summary>
        [Description("未排期")]
        NotScheduling = 4,
        /// <summary>
        /// 进行中（已安排发放）
        /// </summary>
        [Description("进行中")]
        InProgress = 8,
        /// <summary>
        /// 已完成（所有福利排期均已完成）
        /// </summary>
        [Description("已完成")]
        Done = 16,
        /// <summary>
        /// 已关闭（人为关闭福利）
        /// </summary>
        [Description("已关闭")]
        Closed = 32
    }
}
