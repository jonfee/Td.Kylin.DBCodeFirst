using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 商家商品标识
    /// </summary>
    public enum MerchantProductTag
    {
        /// <summary>
        /// 新品
        /// </summary>
        [Description("新品")]
        New = 1,
        /// <summary>
        /// 人气/热卖
        /// </summary>
        [Description("热卖")]
        Hot = 2
    }
}
