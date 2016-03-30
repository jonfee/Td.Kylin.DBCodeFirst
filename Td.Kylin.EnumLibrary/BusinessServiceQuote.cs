

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 上门预约服务报价方式
    /// </summary>
    public enum BusinessServiceQuote
    {
        /// <summary>
        /// 下单时报价
        /// </summary>
        [Description("下单时报价")]
        WhenOrder = 1,
        /// <summary>
        /// 见面时报价
        /// </summary>
        [Description("见面时报价")]
        WhenMeeting = 2
    }
}
