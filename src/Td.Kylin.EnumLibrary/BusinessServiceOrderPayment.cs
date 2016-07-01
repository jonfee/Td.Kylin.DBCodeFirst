

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 上门预约服务订单支付方式
    /// </summary>
    public enum BusinessServiceOrderPayment
    {
        /// <summary>
        /// 余额支付
        /// </summary>
        [Description("余额支付")]
        Balance = 1,
        /// <summary>
        /// 支付宝支付
        /// </summary>
        [Description("支付宝支付")]
        Alipay = 2,
        /// <summary>
        /// 微信支付
        /// </summary>
        [Description("微信支付")]
        WeiXin = 4,
        /// <summary>
        /// 线下付款
        /// </summary>
        [Description("线下付款")]
        OffLine = 8
    }
}
