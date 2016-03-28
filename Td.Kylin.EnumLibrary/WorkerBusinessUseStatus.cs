using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 个人服务者从事业务使用状态
    /// </summary>
    public enum WorkerBusinessUseStatus
    {
        /// <summary>
        /// 申请中
        /// </summary>
        [Description("申请中")]
        Application = 1,
        /// <summary>
        /// 申请失败
        /// </summary>
        [Description("申请失败")]
        ApplyFailure = 2,
        /// <summary>
        /// 使用中
        /// </summary>
        [Description("使用中")]
        Use = 4,
        /// <summary>
        /// 服务暂停
        /// </summary>
        [Description("服务暂停")]
        Pause = 8,
        /// <summary>
        /// 被关闭
        /// </summary>
        [Description("被关闭")]
        Closed = 16
    }
}
