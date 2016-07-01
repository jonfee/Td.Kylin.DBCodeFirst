

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// B2C商品推荐位置
    /// </summary>
    public enum B2CProductRecommendPosition
    {
        /// <summary>
        /// 推荐到淘一淘
        /// </summary>
        [Description("推荐到淘一淘")]
        Tao = 1,
        /// <summary>
        /// 推荐到精品汇
        /// </summary>
        [Description("推荐到精品汇")]
        B2C = 2,
        /// <summary>
        /// 推荐到分类
        /// </summary>
        [Description("推荐到分类")]
        Category = 4
    }
}
