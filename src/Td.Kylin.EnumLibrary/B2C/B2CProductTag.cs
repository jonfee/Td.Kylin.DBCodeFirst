﻿

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// B2C商品标识
    /// </summary>
    public enum B2CProductTag
    {
        /// <summary>
        /// 新品
        /// </summary>
        [Description("新品")]
        New = 1,
        /// <summary>
        /// 人气/热卖
        /// </summary>
        [Description("热卖")]
        Hot = 2
    }

    /// <summary>
    /// B2C促销标识
    /// </summary>
    public enum B2CPromotionTagStatus
    {
        /// <summary>
        /// 限时购
        /// </summary>
        [Description("限时购")]
        Limit = 1,
    }
}
