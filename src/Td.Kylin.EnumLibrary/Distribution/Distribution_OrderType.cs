using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 订单业务类型
    /// </summary>
    public enum Distribution_OrderType
    {
        /// <summary>
        /// 	商城订单
        /// </summary>   
        [Description("商城订单")]
        MallOrder = 1,
        /// <summary>
        /// 同城跑腿
        /// </summary>
        [Description("同城跑腿")]
        LegworkOrder = 2,
    }
}
