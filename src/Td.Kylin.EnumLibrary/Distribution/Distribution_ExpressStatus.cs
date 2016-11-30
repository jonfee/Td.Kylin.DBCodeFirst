using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    ///  快递物流状态
    /// </summary>
    public enum Distribution_ExpressStatus
    {
        /// <summary>
        /// 待发货
        /// </summary>
        [Description("待发货")]
        WaitingDelivery = 1,
        /// <summary>
        /// 待收货
        /// </summary>
        [Description("待收货")]
        WaitingReceipt = 2,
        /// <summary>
        /// 已签收
        /// </summary>
        [Description("已签收")]
        Completed = 3,
        /// <summary>
        /// 已取消
        /// </summary>
        [Description("已取消")]
        Canceled = 4
    }
}
