using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 业务积分上限单位
    /// </summary>
    public enum ScoreMaxLimitUnit
    {
        /// <summary>
        /// 每次
        /// </summary>
        [Description("每次")]
        Times = 1,
        /// <summary>
        /// 每天
        /// </summary>
        [Description("每天")]
        Day = 2
    }
}
