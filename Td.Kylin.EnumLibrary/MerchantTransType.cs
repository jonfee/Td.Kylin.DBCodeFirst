

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 商家交易类型
    /// </summary>
    public enum MerchantTransType
    {
        /// <summary>
        /// 销售商品
        /// </summary>
        [Description("销售商品")]
        ProductSales = 1,
        /// <summary>
        /// 销售/提供服务
        /// </summary>
        [Description("销售/提供服务")]
        ServiceSales = 2,
        /// <summary>
        /// 上门服务中支付用户费用（一般用于上门回收垃圾等服务中）
        /// </summary>
        [Description("上门服务中支付用户费用")]
        InServicePaymentToUser = 4,
        /// <summary>
        /// 返佣金给工作人员
        /// </summary>
        [Description("返佣金给工作人员")]
        ReturnCommissionToWorker = 8,
        /// <summary>
        /// 充退回款
        /// </summary>
        [Description("充退回款")]
        Drawback = 16,
        /// <summary>
        /// 提现
        /// </summary>
        [Description("提现")]
        Withdraw = 32,
        /// <summary>
        /// 用户转账/买单
        /// </summary>
        [Description("用户转账/买单")]
        UserTransfer = 64
    }
}
