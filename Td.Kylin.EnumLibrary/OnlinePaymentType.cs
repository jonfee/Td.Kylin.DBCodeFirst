using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 线上支付方式
    /// </summary>
    public enum OnlinePaymentType
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
        WeiXinPay = 4
    }
}
