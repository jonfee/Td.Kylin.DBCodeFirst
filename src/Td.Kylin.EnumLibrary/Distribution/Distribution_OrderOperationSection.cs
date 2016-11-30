using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 配送订单操作节点
    /// </summary>
    public enum Distribution_OrderOperationSection
    {
        /// <summary>
        /// 分配环节
        /// </summary>
        [Description("分配环节")]
        Assign = 1,
        /// <summary>
        /// 配送环节
        /// </summary>
        [Description("配送环节")]
        Delivery = 2
    }
}
