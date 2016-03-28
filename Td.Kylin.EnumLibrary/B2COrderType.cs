using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// B2C订单类型
    /// </summary>
    public enum B2COrderType
    {
        /// <summary>
        /// 商城订单
        /// </summary>
        [Description("商城订单")]
        MallOrder = 1,
        /// <summary>
        /// 摇一摇订单
        /// </summary>
        [Description("摇一摇订单")]
        ShakeOrder = 2
    }
}
