using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary.B2C
{
    /// <summary>
    /// 订单配送方式
    /// </summary>
    public enum MallDistributionMethod
    {
        /// <summary>
        /// 同城配送
        /// 系统指派所获得的。
        /// </summary>
        [Description("同城配送")]
        Legwork = 1,
        /// <summary>
        /// 快递物流
        ///手动抢单所获得的。 
        /// </summary>
        [Description("快递物流")]
        Express = 2,
    }
}
