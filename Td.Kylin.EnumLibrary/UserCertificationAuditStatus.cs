using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 用户认证审核状态
    /// </summary>
    public enum UserCertificationAuditStatus
    {
        /// <summary>
        /// 审核中
        /// </summary>
        [Description("审核中")]
        Auditing = 1,
        /// <summary>
        /// 审核成功
        /// </summary>
        [Description("审核成功")]
        Success = 2,
        /// <summary>
        /// 审核失败
        /// </summary>
        [Description("审核失败")]
        Failure = 4
    }
}
