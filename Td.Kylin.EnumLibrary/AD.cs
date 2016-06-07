

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
    /// 广告数据类型
    /// </summary>
    public enum ADType
    {
        /// <summary>
        /// 图片
        /// </summary>
        [Description("图片")]
        Image = 1,
        /// <summary>
        /// 文字
        /// </summary>
        [Description("文字")]
        Text = 2,
        /// <summary>
        /// 视频
        /// </summary>
        [Description("视频")]
        Video = 4
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
        SingleImage = 2,
        /// <summary>
        /// 滑动跳过
        /// </summary>
        [Description("滑动跳过")]
        SlidePass =4,
        /// <summary>
        /// 定时跳过
        /// </summary>
        [Description("定时跳过")]
        TimerPass =8
    }

    /// <summary>
    /// 广告链接类型
    /// </summary>
    public enum ADLinkType
    {
        /// <summary>
        /// 网址
        /// </summary>
        [Description("网址")]
        UrlLink = 1,
        /// <summary>
        /// 精品汇商品
        /// </summary>
        [Description("精品汇商品")]
        B2CProduct = 2,
        /// <summary>
        /// 商家商品
        /// </summary>
        [Description("商家商品")]
        MerchantProduct = 4,
        /// <summary>
        /// 商家
        /// </summary>
        [Description("商家")]
        MerchantDetails = 8,
        /// <summary>
        /// 社区活动帖
        /// </summary>
        [Description("社区活动帖")]
        CircleEvent = 16
    }
}
