using System;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 跑腿订单状态。
    /// </summary>
    public enum LegworkOrderStatus : short
    {
        /// <summary>
        /// 待接单。
        /// </summary>
        [Description("待接单。")]
        WaitingHandle = 1,

        /// <summary>
        /// 待支付。
        /// </summary>
        [Description("待支付。")]
        WaitingPayment = 2,

        /// <summary>
        /// 待取货。
        /// </summary>
        [Description("待取货。")]
        WaitingPick = 4,

        /// <summary>
        /// 配送中。
        /// </summary>
        [Description("配送中。")]
        InDeliver = 8,

        /// <summary>
        /// 已送达。
        /// </summary>
        [Description("已送达。")]
        Delivered = 16,

        /// <summary>
        /// 已完成。
        /// </summary>
        [Description("已完成。")]
        Complete = 32,

        /// <summary>
        /// 已评价。
        /// </summary>
        [Description("已评价。")]
        Evaluated = 64,

        /// <summary>
        /// 已取消。
        /// </summary>
        [Description("已取消。")]
        Canceled = 128,

        /// <summary>
        /// 已失效。
        /// </summary>
        [Description("已失效。")]
        Invalid = 256
    }
}
