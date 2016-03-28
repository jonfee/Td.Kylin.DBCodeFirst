using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 商家商品推荐位置
    /// </summary>
    public enum MerchantProductRecommendPosition
    {
        /// <summary>
        /// 推荐到淘一淘
        /// </summary>
        [Description("推荐到淘一淘")]
        Tao = 1,
        /// <summary>
        /// 推荐到附近购
        /// </summary>
        [Description("推荐到附近购")]
        NearBuy = 2,
        /// <summary>
        /// 推荐到分类
        /// </summary>
        [Description("推荐到分类")]
        Category = 4
    }
}
