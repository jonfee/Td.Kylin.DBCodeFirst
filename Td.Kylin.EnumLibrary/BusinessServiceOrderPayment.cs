using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 上门预约服务订单支付方式
    /// </summary>
    public enum BusinessServiceOrderPayment
    {
        /// <summary>
        /// 线下付款
        /// </summary>
        [Description("线下付款")]
        OffLine = 1,
        /// <summary>
        /// 余额支付
        /// </summary>
        [Description("summary")]
        Balance = 2,
        /// <summary>
        /// 微信支付
        /// </summary>
        [Description("微信支付")]
        WeiXin = 4,
        /// <summary>
        /// 支付宝支付
        /// </summary>
        [Description("支付宝支付")]
        Alipay = 8
    }
}
