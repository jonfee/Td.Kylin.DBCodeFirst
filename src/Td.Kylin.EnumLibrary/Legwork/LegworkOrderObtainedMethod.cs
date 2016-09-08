using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary.Legwork
{
    /// <summary>
    /// 配送订单获取方式
    /// </summary>
    public enum LegworkOrderObtainedMethod
    {
        /// <summary>
        /// 系统指派
        /// 系统指派所获得的。
        /// </summary>
        [Description("系统指派")]
        Appointed = 1,
        /// <summary>
        /// 手动抢单
        ///手动抢单所获得的。 
        /// </summary>
        [Description("手动抢单")]
        Requested = 2,
    }
}
