using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary.Merchant
{
    /// <summary>
    /// 商家订单类型
    /// </summary>
    public enum MerchantOrderType
    {
        /// <summary>
        /// 商家商品
        /// </summary>
        [Description("商家商品")]
        Product = 1,
        /// <summary>
        /// 商家生活服务
        /// </summary>
        [Description("商家生活服务")]
        Service = 2
    }
}
