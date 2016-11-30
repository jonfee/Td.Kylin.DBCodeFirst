using Td.ComponentModel;
namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 配送员操作类型
    /// </summary>
    public enum Distribution_MemberOperationType
    {
        /// <summary>
        /// 登录系统
        /// </summary>
        [Description("登录系统")]
        Login = 1,
        /// <summary>
        /// 登出系统
        /// </summary>
        [Description("登出系统")]
        LoginOut = 2,
        /// <summary>
        /// 上班打卡
        /// </summary>
        [Description("上班打卡")]
        StartWork = 3,
        /// <summary>
        /// 下班打卡
        /// </summary>
        [Description("下班打卡")]
        EndWork = 4,
        /// <summary>
        /// 订单配送
        /// </summary>
        [Description("订单配送")]
        Delivery = 5,

    }
}
