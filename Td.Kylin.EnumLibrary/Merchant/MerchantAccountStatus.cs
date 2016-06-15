

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 商户状态
    /// </summary>
    public enum MerchantAccountStatus
    {
        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]
        Normal = 1,
        /// <summary>
        /// 已锁定
        /// </summary>
        [Description("已锁定")]
        Locked = 2,
        /// <summary>
        /// 未审核
        /// </summary>
        [Description("未审核")]
        UnAudited = 3,
    }
}
