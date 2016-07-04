using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    public enum Luckydraw_TicketGivingRules
    {
		/// <summary>
		/// 实付金额满XX元
		/// </summary>
		[Description("实付金额满XX元")]
		[Alias("{ Min : {0} }")]
		PaymentAmount =1,
	}
}
