

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 时间
    /// </summary>
    public enum TimeOption
    {
        /// <summary>
        /// 年
        /// </summary>
        [Description("年")]
        Year = 1,
        /// <summary>
        /// 月
        /// </summary>
        [Description("月")]
        Month = 2,
        /// <summary>
        /// 天
        /// </summary>
        [Description("天")]
        Day = 3,
        /// <summary>
        /// 小时
        /// </summary>
        [Description("小时")]
        Hour = 4,
        /// <summary>
        /// 分钟
        /// </summary>
        [Description("分钟")]
        Minute = 5,
        /// <summary>
        /// 秒钟
        /// </summary>
        [Description("秒钟")]
        Second = 6
    }
}
