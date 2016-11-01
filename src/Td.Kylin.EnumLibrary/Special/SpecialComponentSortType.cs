using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary.Special
{
    /// <summary>
    /// 商品组件排序方式枚举
    /// </summary>
    public enum ComponentProductSortType
    {
        /// <summary>
        /// 发布时间由近到远
        /// </summary>
        [Description("发布时间由近到远")]
        PulishTimeDesc = 1,
        /// <summary>
        /// 发布时间由远到近
        /// </summary>
        [Description("发布时间由远到近")]
        PulishTimeAsc = 2,
        /// <summary>
        /// 价格从低到高
        /// </summary>
        [Description("价格从低到高")]
        PriceAsc = 3,
        /// <summary>
        /// 价格从高到低
        /// </summary>
        [Description("价格从高到低")]
        PriceDesc = 4,
        /// <summary>
        /// 销量从高到低
        /// </summary>
        [Description("销量从高到低")]
        SalesDesc = 5,
        /// <summary>
        /// 销量从低到高
        /// </summary>
        [Description("销量从低到高")]
        SalesAsc = 6
    }
}
