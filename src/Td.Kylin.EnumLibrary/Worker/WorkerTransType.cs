

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 工作人员交易类型
    /// </summary>
    public enum WorkerTransType
    {
        /// <summary>
        /// 销售/提供服务
        /// </summary>
        [Description("销售/提供服务")]
        ServiceSales = 1,
        /// <summary>
        /// 上门服务中支付用户费用（一般用于上门回收垃圾等服务中）
        /// </summary>
        [Description("上门服务中支付用户费用")]
        InServicePayment = 2,
        /// <summary>
        /// 返佣金给运营商（一般用于个人服务者）
        /// </summary>
        [Description("返佣金给运营商")]
        ReturnCommission = 4
    }
}
