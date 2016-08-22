using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary.Operator
{
    /// <summary>
    /// 运营商账号状态枚举
    /// </summary>
    public enum OperatorAccountStatus
    {
        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]
        Normal = 1,
        /// <summary>
        /// 锁定
        /// </summary>
        [Description("锁定")]
        Locked = 2
    }

    /// <summary>
    /// 运营商子账号状态枚举
    /// </summary>
    public enum OperatorSubAccountStatus
    {
        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]
        Normal = 1,
        /// <summary>
        /// 锁定
        /// </summary>
        [Description("锁定")]
        Locked = 2
    }

    /// <summary>
    /// 运营商子账号角色
    /// </summary>
    public enum OperatorSubAccountRole
    {
        /// <summary>
        /// 普通管理员
        /// </summary>
        [Description("普通管理员")]
        Normal = 1
    }
}
