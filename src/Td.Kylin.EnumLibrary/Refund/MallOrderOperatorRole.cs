using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary.Refund
{
    /// <summary>
    /// 直营退款订单操作者角色
    /// </summary>
    public enum MallOrderOperatorRole
    {
        /// <summary>
        /// 买家
        /// </summary>
        [Description("买家")]
        ORDER_BUYER =1,
        /// <summary>
        /// 卖家
        /// </summary>
        [Description("卖家")]
        ORDER_VENDOR =2
    }
}
