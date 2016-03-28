using Td.ComponentModel;

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
        [Description("用户端")]
        UserClient = 1,
        /// <summary>
        /// 商户端
        /// </summary>
        [Description("商户端")]
        MerchantClient = 2,
        /// <summary>
        /// 工作端
        /// </summary>
        [Description("工作端")]
        WorkerClient = 4
    }

    /// <summary>
    /// 广告展示类型
    /// </summary>
    public enum ADDisplayType
    {
        /// <summary>
        /// 图片轮播
        /// </summary>
        [Description("图片轮播")]
        Viwepager = 1,
        /// <summary>
        /// 单图显示
        /// </summary>
        [Description("单图显示")]
        SingleImage =2
    }
}
