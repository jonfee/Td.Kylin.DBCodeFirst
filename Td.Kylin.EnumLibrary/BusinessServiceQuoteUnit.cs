using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 上门预约计价单位
    /// </summary>
    public enum BusinessServiceQuoteUnit
    {
        /// <summary>
        /// 小时
        /// </summary>
        [Description("小时")]
        Hour = 1,
        /// <summary>
        /// 天
        /// </summary>
        [Description("天")]
        Day = 2,
        /// <summary>
        /// 月
        /// </summary>
        [Description("月")]
        Month = 4,
        /// <summary>
        /// 台
        /// </summary>
        [Description("台")]
        Tai = 8,
        /// <summary>
        /// 件
        /// </summary>
        [Description("件")]
        Jian = 16
    }
}
