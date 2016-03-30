

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 社区帖子回应类型
    /// </summary>
    public enum CircleRespondType
    {
        /// <summary>
        /// 评论/回复
        /// </summary>
        [Description("评论/回复")]
        Review = 1,
        /// <summary>
        /// 支持/点赞
        /// </summary>
        [Description("支持/点赞")]
        Support = 2,
        /// <summary>
        /// 反对/踩帖
        /// </summary>
        [Description("反对/踩帖")]
        Oppose = 4
    }
}
