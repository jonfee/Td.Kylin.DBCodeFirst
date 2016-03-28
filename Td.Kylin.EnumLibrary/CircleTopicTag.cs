using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 社区帖子标识
    /// </summary>
    public enum CircleTopicTag
    {
        /// <summary>
        /// 置顶
        /// </summary>
        [Description("置顶")]
        Top = 1,
        /// <summary>
        /// 推荐
        /// </summary>
        [Description("推荐")]
        Recommend = 2,
        /// <summary>
        /// 精华
        /// </summary>
        [Description("精华")]
        Essence = 4,
        /// <summary>
        /// 热帖
        /// </summary>
        [Description("热帖")]
        Hot = 8,
        /// <summary>
        /// 摇一摇申请中
        /// </summary>
        [Description("摇一摇申请中")]
        ShakeAuditing = 16,
        /// <summary>
        /// 摇一摇使用中
        /// </summary>
        [Description("摇一摇使用中")]
        ShakeUse = 32
    }
}
