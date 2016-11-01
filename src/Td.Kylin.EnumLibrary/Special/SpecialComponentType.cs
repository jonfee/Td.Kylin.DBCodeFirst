using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 专题组件类型
    /// </summary>
    public enum SpecialComponentType
    {
        /// <summary>
        /// 单图
        /// </summary>
        [Description("单图")]
        SingleImage = 10,
        /// <summary>
        /// 优惠券
        /// </summary>
        [Description("优惠券")]
        Coupon = 20,
        /// <summary>
        /// 普通商品
        /// </summary>
        [Description("普通商品")]
        OrdinaryProduct = 30
    }
}
