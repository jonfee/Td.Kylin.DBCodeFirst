

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 上门服务业务类型
    /// </summary>
    public enum ServicesBusinessType
    {
        /// <summary>
        /// 上门服务
        /// </summary>
        [Description("上门服务")]
        Visit = 1,
        /// <summary>
        /// 预约服务
        /// </summary>
        [Description("预约服务")]
        Subscribe = 2
    }
}
