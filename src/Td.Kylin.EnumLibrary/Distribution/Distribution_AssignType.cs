using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 订单指派方式
    /// </summary>
    public enum Distribution_AssignType
    {
        /// <summary>
        /// 系统指派
        /// </summary>
        [Description("系统自动指派")]
        Automatic = 1 ,
        /// <summary>
        /// 手动指派
        /// </summary>
        [Description("人为手动指派")]
        Manually = 2
    }
}
