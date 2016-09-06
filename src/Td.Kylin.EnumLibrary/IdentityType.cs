using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 身份类型
    /// </summary>
    public enum IdentityType
    {
        /// <summary>
        /// 普通用户
        /// </summary>
        [Description("普通用户")]
        User = 1,
        /// <summary>
        /// 服务者
        /// </summary>
        [Description("服务者")]
        Worker = 2,
        /// <summary>
        /// 商家
        /// </summary>
        [Description("商家")]
        Merchant = 4,
        /// <summary>
        /// 区域运营商
        /// </summary>
        [Description("区域运营商")]
        AreaOperator = 8,
        /// <summary>
        /// 系统平台
        /// </summary>
        [Description("系统平台")]
        Platform = 16
    }
}
