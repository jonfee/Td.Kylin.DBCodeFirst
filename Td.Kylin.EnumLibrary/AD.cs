namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 广告投放终端
    /// </summary>
    public enum ADTerminal
    {
        /// <summary>
        /// 用户端
        /// </summary>
        UserClient = 1,
        /// <summary>
        /// 商户端
        /// </summary>
        MerchantClient = 2,
        /// <summary>
        /// 工作端
        /// </summary>
        WorkerClient = 4
    }

    /// <summary>
    /// 广告内容类型
    /// </summary>
    public enum ADContentType
    {
        /// <summary>
        /// 图片
        /// </summary>
        Image=1,
        /// <summary>
        /// 文字
        /// </summary>
        Text=2,
        /// <summary>
        /// 视频
        /// </summary>
        Vedio=4
    }
}
