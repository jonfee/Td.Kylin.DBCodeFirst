using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 幸运抽奖奖券类型
    /// </summary>
    public enum Luckydraw_TicketType
    {
		/// <summary>
		/// 通用券
		/// </summary>
		[Description("通用券")]
		GlobalTicket=1,


		/// <summary>
		/// 奖品券
		/// </summary>
		[Description("奖品券")]
		PrizeTicket=2
	}
}
