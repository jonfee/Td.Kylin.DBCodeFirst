

using Td.ComponentModel;

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
        [Description("余额充值")]
        Recharge = 1,
        /// <summary>
        /// 购买商品
        /// </summary>
        [Description("购买商品")]
        BuyGoods = 2,
        /// <summary>
        /// 支付服务费
        /// </summary>
        [Description("支付服务费")]
        BuyServies = 4,
        /// <summary>
        /// 充退回款
        /// </summary>
        [Description("充退回款")]
        Drawback = 8,
        /// <summary>
        /// 提现
        /// </summary>
        [Description("提现")]
        Withdraw = 16,
        /// <summary>
        /// 获得服务佣金
        /// </summary>
        [Description("获得服务佣金")]
        GetWorkCommission = 32,
        /// <summary>
        /// 服务收款
        /// </summary>
        [Description("服务收款")]
        Proceeds = 64,
        /// <summary>
        /// 转账付款
        /// </summary>
        [Description("转账付款")]
        Transfer = 128
    }
}
