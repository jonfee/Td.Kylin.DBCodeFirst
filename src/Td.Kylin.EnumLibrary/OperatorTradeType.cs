using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 运营商交易记录类型
    /// </summary>
    public enum OperatorTradeType
    {
        /// <summary>
        /// 销售商品
        /// </summary>
        [Description("销售商品")]
        SaleProduct = 1,
        /// <summary>
        /// 抽成获得
        /// </summary>
        [Description("抽成获得")]
        CommissionGet = 2,
        /// <summary>
        /// 支付佣金
        /// </summary>
        [Description("支付佣金")]
        PayCommission = 4
    }
}
