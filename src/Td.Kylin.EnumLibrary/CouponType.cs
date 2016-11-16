
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 优惠券类型
    /// </summary>

    public enum CouponType
    {
        /// <summary>
        /// 通用券，可针对任意商品有效
        /// </summary>
        [Description("通用券")]
        Global = 1,
        /// <summary>
        /// 品类券，仅针对指定商品分类有效
        /// </summary>
        [Description("品类券")]
        Category = 2,
        /// <summary>
        /// 单品券，仅针对指定商品有效
        /// </summary>
        [Description("单品券")]
        Goods = 3,
        /// <summary>
        /// 运费券，仅针对运费有效
        /// </summary>
        [Description("运费券")]
        Freight = 4,
        /// <summary>
        /// 首单券，仅针对首单有效
        /// </summary>
        [Description("首单券")]
        FirstOrder = 5
    }

    /// <summary>
    /// 优惠券规则
    /// </summary>
    public enum CouponRulesType
    {
        /// <summary>
        /// 订单金额满XX元
        /// </summary>
        [Alias("{ OrderAmountMin: {0} }")]
        [Description("订单金额满XX元")]
        OrderAmount = 1,
        /// <summary>
        /// 促销商品可使用
        /// </summary>
        [Alias("{ SupportSalesGoods: {0} }")]
        [Description("促销商品可使用")]
        SupportSalesGoods = 2,
        /// <summary>
        /// 仅支持特定品类
        /// </summary>
        [Alias("{ SpecificCategory: {0} }")]
        [Description("仅支持特定品类")]
        SpecificCategory = 3,
        /// <summary>
        /// 仅支持特定商品
        /// </summary>
        [Alias("{ SpecificGoods: {0} }")]
        [Description("仅支持特定商品")]
        SpecificGoods = 4,
        /// <summary>
        /// 仅支持首单使用
        /// </summary>
        [Alias("{ SupportFirstOrder: {0} }")]
        [Description("仅支持首单使用")]
        SupportFirstOrder =5
    }
}
