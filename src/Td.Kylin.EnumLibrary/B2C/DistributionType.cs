using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 配送方式
    /// </summary>
    public enum DistributionType
    {
        /// <summary>
        /// 同城配送
        /// </summary>
        [Description("同城配送")]
        Legwork = 1,
        /// <summary>
        /// 快递物流
        /// </summary>
        [Description("快递物流")]
        Express = 2,
    }
}
