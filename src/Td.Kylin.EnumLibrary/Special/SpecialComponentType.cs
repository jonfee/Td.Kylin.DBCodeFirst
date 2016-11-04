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
        OrdinaryProduct = 30,
        /// <summary>
        /// 栏目导航
        /// </summary>
        [Description("栏目导航")]
        Navigation = 40,
        /// <summary>
        /// 底部说明
        /// </summary>
        [Description("底部说明")]
        Foot = 50
    }
}
