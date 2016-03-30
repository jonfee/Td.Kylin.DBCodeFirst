

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 社区活动状态
    /// </summary>
    public enum CircleEventStatus
    {
        /// <summary>
        /// 报名中
        /// </summary>
        [Description("报名中")]
        Apply = 1,
        /// <summary>
        /// 已取消
        /// </summary>
        [Description("已取消")]
        Canceled
    }
}
