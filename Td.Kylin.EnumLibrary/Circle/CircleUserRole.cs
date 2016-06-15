

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 社区用户角色
    /// </summary>
    public enum CircleUserRole
    {
        /// <summary>
        /// 普通用户
        /// </summary>
        [Description("普通用户")]
        Default = 1,
        /// <summary>
        /// 版主
        /// </summary>
        [Description("版主")]
        Moderator = 2,
        /// <summary>
        /// 超级版主
        /// </summary>
        [Description("超级版主")]
        SuperModerator = 4
    }
}
