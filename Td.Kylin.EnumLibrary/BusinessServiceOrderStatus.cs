using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 上门服务订单状态
    /// </summary>
    public enum VisitingServiceOrderStatus
    {
        /// <summary>
        /// 等待商家接单
        /// </summary>
        [Description("等待商家接单")]
        WaitingMerchantReceive = 1,
        /// <summary>
        /// 正在安排工作人员
        /// </summary>
        [Description("正在安排工作人员")]
        WaitingAllocation = 2,
        /// <summary>
        /// 等待工作人员上门
        /// </summary>
        [Description("等待工作人员上门")]
        WaitingVisiting = 4,
        /// <summary>
        /// 工作人员开始工作
        /// </summary>
        [Description("工作人员开始工作")]
        Working = 8,
        /// <summary>
        /// 工作人员已报价
        /// </summary>
        [Description("工作人员已报价")]
        WorkerQuoted = 16,
        /// <summary>
        /// 用户已确定报价
        /// </summary>
        [Description("用户已确定报价")]
        UserConfirmQuote = 32,
        /// <summary>
        /// 工作人员完成服务
        /// </summary>
        [Description("工作人员完成服务")]
        WorkerServiceDone = 64,
        /// <summary>
        /// 用户确定服务完成
        /// </summary>
        [Description("用户确定服务完成")]
        UserServiceConfirmDone = 128,
        /// <summary>
        /// 用户已评价
        /// </summary>
        [Description("用户已评价")]
        UserEvaluated = 256,
        /// <summary>
        /// 订单已取消
        /// </summary>
        [Description("订单已取消")]
        Cancel = 512
    }

    /// <summary>
    /// 预约服务订单状态
    /// </summary>
    public enum ReservationServiceOrderStatus
    {
        /// <summary>
        /// 等待商家接单
        /// </summary>
        [Description("等待商家接单")]
        WaitingMerchantReceive = 1,
        /// <summary>
        /// 正在安排相关服务工作
        /// </summary>
        [Description("正在安排相关服务工作")]
        WaitingAllocation = 2,
        /// <summary>
        /// 商家提交服务方案
        /// </summary>
        [Description("商家提交服务方案")]
        MerchantSubmitSolution = 4,
        /// <summary>
        /// 用户已确定服务方案
        /// </summary>
        [Description("用户已确定服务方案")]
        UserConfirmSolution = 8,
        /// <summary>
        /// 工作人员完成服务
        /// </summary>
        [Description("工作人员完成服务")]
        MerchantServiceDone = 16,
        /// <summary>
        /// 用户确定服务完成
        /// </summary>
        [Description("用户确定服务完成")]
        UserServiceConfirmDone = 32,
        /// <summary>
        /// 用户已评价
        /// </summary>
        [Description("用户已评价")]
        UserEvaluated = 64,
        /// <summary>
        /// 订单已取消
        /// </summary>
        [Description("订单已取消")]
        Cancel = 128
    }
}
