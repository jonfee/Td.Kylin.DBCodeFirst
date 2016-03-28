using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 上门预约服务订单的服务提供者类型
    /// </summary>
    public enum BusinessOrderServiceProvider
    {
        /// <summary>
        /// 商家提供
        /// </summary>
        [Description("商家提供")]
        Merchant = 1,
        /// <summary>
        /// 个人提供
        /// </summary>
        [Description("个人提供")]
        Person = 2
    }
}
