using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 商家订单配送方式
    /// </summary>
    public enum MerchantOrderDeliveryMode
    {
        /// <summary>
        /// 商家配送
        /// </summary>
        [Description("商家配送")]
        MerchantShip = 1,
        /// <summary>
        /// 到店自取
        /// </summary>
        [Description("到店自取")]
        ComeInShop = 2
    }
}
