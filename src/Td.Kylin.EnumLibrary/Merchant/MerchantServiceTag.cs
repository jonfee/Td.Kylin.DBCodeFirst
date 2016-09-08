using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 商家服务方式标签
    /// </summary>
    public enum MerchantServiceTag
    {
        /// <summary>
        /// 上门
        /// </summary>
        [Description("上门")]
        Call = 1,
        /// <summary>
        /// 自提
        /// </summary>
        [Description("自提")]
        Take = 2
    }
}
