using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 商家订单状态
    /// </summary>
    public enum MerchantOrderStatus
    {
        /// <summary>
        /// 待付款
        /// </summary>
        [Description("待付款")]
        WaitingPayment = 1,
        /// <summary>
        /// 待发货
        /// </summary>
        [Description("待发货")]
        WaitingDelivery = 2,
        /// <summary>
        /// 待收货
        /// </summary>
        [Description("待收货")]
        WaitingReceipt = 4,
        /// <summary>
        /// 已完成
        /// </summary>
        [Description("已完成")]
        Done = 8,
        /// <summary>
        /// 已取消
        /// </summary>
        [Description("已取消")]
        Canceled = 16
    }
    /// <summary>
    /// 商家服务订单状态
    /// </summary>
    public enum MerchantServiceStatus
    {
        /// <summary>
        /// 待付款
        /// </summary>
        [Description("待付款")]
        WaitingPayment = 1,
        /// <summary>
        /// 待发货
        /// </summary>
        [Description("待发货")]
        WaitingDelivery = 2,
        /// <summary>
        /// 待收货
        /// </summary>
        [Description("待收货")]
        WaitingReceipt = 4,
        /// <summary>
        /// 已完成
        /// </summary>
        [Description("已完成")]
        Done = 8,
        /// <summary>
        /// 已取消
        /// </summary>
        [Description("已取消")]
        Canceled = 16,
        /// <summary>
        /// 已评价
        /// </summary>
        [Description("已评价")]
        Evaluate = 32,
    }
}
