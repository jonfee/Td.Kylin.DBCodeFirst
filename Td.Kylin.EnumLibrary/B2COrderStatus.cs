namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// B2C订单状态
    /// </summary>
    public enum B2COrderStatus
    {
        /// <summary>
        /// 待付款
        /// </summary>
        WaitingPayment = 1,
        /// <summary>
        /// 待发货
        /// </summary>
        WaitingDelivery = 2,
        /// <summary>
        /// 待收货
        /// </summary>
        WaitingReceipt = 4,
        /// <summary>
        /// 已完成
        /// </summary>
        None = 8,
        /// <summary>
        /// 已取消
        /// </summary>
        Canceled = 16
    }
}
