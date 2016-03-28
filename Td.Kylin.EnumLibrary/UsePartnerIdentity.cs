using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 使用者身份
    /// </summary>
    public enum UsePartnerIdentity
    {
        /// <summary>
        /// 普通用户
        /// </summary>
        [Description("普通用户")]
        DefaultUser = 1,
        /// <summary>
        /// 商家
        /// </summary>
        [Description("商家")]
        Merchant = 2,
        /// <summary>
        /// 员工
        /// </summary>
        [Description("员工")]
        Worker = 3
    }
}
