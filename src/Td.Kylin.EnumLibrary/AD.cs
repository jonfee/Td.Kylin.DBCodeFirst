

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
        SlidePass = 4,
        /// <summary>
        /// 定时跳过
        /// </summary>
        [Description("定时跳过")]
        TimerPass = 8
    }

    /// <summary>
    /// 广告链接类型
    /// </summary>
    public enum ADLinkType
    {
        /// <summary>
        /// 外部链接
        /// </summary>
        [Description("外部链接")]
        UrlLink = 1,
        /// <summary>
        /// 全心直营商品
        /// </summary>
        [Description("全心直营商品")]
        B2CProduct = 2,
        /// <summary>
        /// 直营分类商品
        /// </summary>
        [Description("直营分类商品")]
        B2CCategoryProduct = 3,
        ///// <summary>
        ///// 商家商品
        ///// </summary>
        //[Description("商家商品")]
        //MerchantProduct = 4,
        ///// <summary>
        ///// 商家
        ///// </summary>
        //[Description("商家")]
        //MerchantDetails = 8,
        /// <summary>
        /// 社区圈子
        /// </summary>
        [Description("社区圈子")]
        CircleFourm = 15,
        /// <summary>
        /// 社区帖子
        /// </summary>
        [Description("社区帖子")]
        CircleTopic = 16,
        /// <summary>
        /// 专题
        /// </summary>
        [Description("专题")]
        Special = 18,
        /// <summary>
        /// 频道页
        /// </summary>
        [Description("频道页")]
        ChannelnPage = 99,
    }

    /// <summary>
    /// 广告频道页枚举
    /// </summary>
    public enum AdChannelnPage
    {
        /// <summary>
        /// 摇一摇
        /// </summary>
        [Description("摇一摇")]
        Shake = 1,
        /// <summary>
        /// 领券中心
        /// </summary>
        [Description("领券中心")]
        CouponCenter = 2,
        /// <summary>
        /// 全心直营
        /// </summary>
        [Description("全心直营")]
        QmallZY = 3,
        /// <summary>
        /// 精选实惠
        /// </summary>
        [Description("精选实惠")]
        QmallJXSH = 4,
        /// <summary>
        /// 限时抢购
        /// </summary>
        [Description("限时抢购")]
        QmallXSQG = 5,
        /// <summary>
        /// 此刻推荐
        /// </summary>
        [Description("此刻推荐")]
        MomentRecommend = 6,
        /// <summary>
        /// 同城跑腿
        /// </summary>
        [Description("同城跑腿")]
        RunErrands = 7
    }
}
