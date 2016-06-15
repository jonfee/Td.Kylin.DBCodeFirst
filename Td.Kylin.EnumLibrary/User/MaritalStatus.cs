

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 婚姻状况
    /// </summary>
    public enum MaritalStatus
    {
        /// <summary>
        /// 未婚
        /// </summary>
        [Description("未婚")]
        Unmarried = 1,
        /// <summary>
        /// 已婚
        /// </summary>
        [Description("已婚")]
        Married = 2,
        /// <summary>
        /// 离异
        /// </summary>
        [Description("离异")]
        Divorced = 4,
        /// <summary>
        /// 丧偶
        /// </summary>
        [Description("丧偶")]
        Widowed = 8
    }
}
