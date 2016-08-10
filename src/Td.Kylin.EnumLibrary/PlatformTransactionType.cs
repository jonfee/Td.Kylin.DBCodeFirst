using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 平台资金流水交易类型
    /// </summary>
    public enum PlatformTransactionType
    {
        /// <summary>
        /// 用户充值
        /// </summary>
        [Description("用户充值")]
        UserRecharge = 1,
        /// <summary>
        /// 用户提现
        /// </summary>
        [Description("用户提现")]
        UserWithdraw = 2,
        /// <summary>
        /// 商家充值
        /// </summary>
        [Description("商家充值")]
        MerchantRecharge = 3,
        /// <summary>
        /// 商家提现
        /// </summary>
        [Description("商家提现")]
        MerchantWithdraw = 4,
        /// <summary>
        /// 转账
        /// </summary>
        [Description("转账")]
        TransMoney = 5,
        /// <summary>
        /// 收款
        /// </summary>
        [Description("收款")]
        ReceiptMoney = 6,
        /// <summary>
        /// 提现手续费
        /// </summary>
        [Description("提现手续费")]
        WithdrawFee = 7,
        /// <summary>
        /// 购买商品
        /// </summary>
        [Description("购买商品")]
        BuyProduct = 8,
        /// <summary>
        /// 销售商品
        /// </summary>
        [Description("销售商品")]
        SaleProduct = 9,
        /// <summary>
        /// 购买服务
        /// </summary>
        [Description("购买服务")]
        BuyService = 10,
        /// <summary>
        /// 提供/销售服务
        /// </summary>
        [Description("提供/销售服务")]
        SaleService = 11,
        /// <summary>
        /// 抽成获得
        /// </summary>
        [Description("抽成获得")]
        CommissionGet = 12,
        /// <summary>
        /// 支付抽成佣金
        /// </summary>
        [Description("支付抽成佣金")]
        PayCommission = 13,
        /// <summary>
        /// 返现
        /// </summary>
        [Description("返现")]
        ReturnMoney = 14,
        /// <summary>
        /// 充退回款
        /// </summary>
        [Description("充退回款")]
        BackMoney = 15,
        /// <summary>
        /// 配送支出
        /// </summary>
        [Description("配送支出")]
        DistributionExpenditure = 16,
        /// <summary>
        /// 配送收入
        /// </summary>
        [Description("配送收入")]
        DistributionIncome = 17
    }
}
