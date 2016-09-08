using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 幸运抽奖奖券使用规则方式
    /// </summary>
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
