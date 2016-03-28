using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 上门预约订单付款方
    /// </summary>
    public enum BusinessServicePayer
    {
        /// <summary>
        /// 第三方客户（下单方，一般指用户）
        /// </summary>
        [Description("第三方客户")]
        Custom = 1,
        /// <summary>
        /// 第三方服务者（一般指商家或个人服务人员）
        /// </summary>
        [Description("第三方服务者")]
        Servicer = 2
    }
}
