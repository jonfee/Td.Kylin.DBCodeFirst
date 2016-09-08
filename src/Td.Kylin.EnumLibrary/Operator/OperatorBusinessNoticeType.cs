using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 运营商业务通知类型枚举
    /// </summary>
    public enum OperatorBusinessNoticeType
    {
        /// <summary>
        /// 身份认证审核通知
        /// </summary>
        [Description("身份认证审核通知")]
        IdentityAudit = 1,
        /// <summary>
        /// 跑腿业务申请审核通知
        /// </summary>
        [Description("跑腿业务申请审核通知")]
        LegworkBusinessApplyAudit = 8,
        /// <summary>
        /// 订单发货通知
        /// </summary>
        [Description("订单发货通知")]
        OrderDispatch = 4,
        /// <summary>
        /// 商品库存预警通知
        /// </summary>
        [Description("商品库存预警通知")]
        ProductInventoryWarning = 16
    }

    /// <summary>
    /// 运营商业务通知途径
    /// </summary>
    public enum OperatorBusinessNoticeWay
    {
        /// <summary>
        /// 手机短信
        /// </summary>
        [Description("手机短信")]
        SMS = 1
    }
}
