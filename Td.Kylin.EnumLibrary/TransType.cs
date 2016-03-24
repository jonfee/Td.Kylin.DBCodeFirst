namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 用户交易类型
    /// </summary>
    public enum UserTransType
    {
        /// <summary>
        /// 余额充值
        /// </summary>
        Recharge = 1,
        /// <summary>
        /// 购买商品
        /// </summary>
        BuyGoods = 2,
        /// <summary>
        /// 支付服务费
        /// </summary>
        BuyServies = 4,
        /// <summary>
        /// 充退回款
        /// </summary>
        Drawback = 8,
        /// <summary>
        /// 提现
        /// </summary>
        Withdraw = 16,
        /// <summary>
        /// 获得服务佣金
        /// </summary>
        GetWorkCommission = 32,
        /// <summary>
        /// 服务收款
        /// </summary>
        Proceeds = 64
    }
}
