using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 用户账号状态
    /// </summary>
    public enum UserAccountStatus
    {
        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]
        Normal = 1,
        /// <summary>
        /// 被封号
        /// </summary>
        [Description("被封号")]
        Banned = 2
    }
}
