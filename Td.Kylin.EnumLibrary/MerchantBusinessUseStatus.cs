namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 商家从事业务使用状态
    /// </summary>
    public enum MerchantBusinessUseStatus
    {
        /// <summary>
        /// 申请中
        /// </summary>
        Application=1,
        /// <summary>
        /// 申请失败
        /// </summary>
        ApplyFailure=2,
        /// <summary>
        /// 使用中
        /// </summary>
        Use=4,
        /// <summary>
        /// 服务暂停
        /// </summary>
        Pause=8,
        /// <summary>
        /// 被关闭
        /// </summary>
        Closed=16
    }
}
