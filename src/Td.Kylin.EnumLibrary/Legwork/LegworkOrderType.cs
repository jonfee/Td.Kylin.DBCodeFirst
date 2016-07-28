using System;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
	/// <summary>
	/// 跑腿订单类型。
	/// </summary>
    public enum LegworkOrderType : short
    {
		/// <summary>
		/// 购买物品。
		/// </summary>
		[Description("购买物品")]
		BuyGoods = 1,

		/// <summary>
		/// 取送物品。
		/// </summary>
		[Description("取送物品")]
		DeliveryGoods = 2,
        /// <summary>
        /// 精品汇订单
        /// </summary>
        [Description("精品汇订单")]
        MallOrder = 3,

    }
}
