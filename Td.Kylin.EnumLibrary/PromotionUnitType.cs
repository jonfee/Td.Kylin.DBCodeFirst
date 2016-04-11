using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 促销配置单位
    /// </summary>
    public enum PromotionUnitType
    {
        /// <summary>
        /// 固定金额
        /// </summary>
        Number = 1,
        /// <summary>
        /// 促销折扣
        /// </summary>
        Percentage = 2,
    }
}
