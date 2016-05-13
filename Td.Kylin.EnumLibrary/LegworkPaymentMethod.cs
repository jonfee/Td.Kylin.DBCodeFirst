using System;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
	/// <summary>
	/// 跑腿订单支付方式。
	/// </summary>
    public enum LegworkPaymentMethod : short
    {
		/// <summary>
		/// 线上支付。
		/// </summary>
		[Description("线上支付")]
		Online = 1,

		/// <summary>
		/// 线下支付。
		/// </summary>
		[Description("线下支付")]
		Offline = 2
	}
}
