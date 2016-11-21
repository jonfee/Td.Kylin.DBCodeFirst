using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 直营退款订单状态
    /// </summary>
    public enum MallRefundOrderStatus
    {
        /// <summary>
        /// 等待受理
        /// </summary>
        [Description("等待受理")]
        WAIT_FOR = 1,
        /// <summary>
        /// 已受理
        /// </summary>
        [Description("已受理")]
        REFUND_ACCEPTED = 2,
        /// <summary>
        /// 退款成功
        /// </summary>
        [Description("退款成功")]
        REFUND_SUCCESS = 3,
        /// <summary>
        /// 退款关闭
        /// </summary>
        [Description("退款关闭")]
        REFUND_CLOSE = 4
    }
}
