using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 上门预约业务类型
    /// </summary>
    public enum BusinessServiceType
    {
        /// <summary>
        /// 上门服务
        /// </summary>
        [Description("上门服务")]
        Visiting = 1,
        /// <summary>
        /// 预约服务
        /// </summary>
        [Description("预约服务")]
        Reservation = 2
    }
}
