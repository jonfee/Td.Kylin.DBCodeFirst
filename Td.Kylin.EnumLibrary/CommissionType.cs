

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 抽成方式
    /// </summary>
    public enum CommissionType
    {
        /// <summary>
        /// 按金额百分比
        /// </summary>
        [Description("按金额百分比")]
        MoneyRate = 1,
        /// <summary>
        /// 按固定金额
        /// </summary>
        [Description("按固定金额")]
        FixedAmount = 2
    }
}
