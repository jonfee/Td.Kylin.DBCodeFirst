using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 用户认证类型
    /// </summary>
    public enum UserCertification
    {
        /// <summary>
        /// 实名认证
        /// </summary>
        [Description("实名认证")]
        RealName = 1,
        /// <summary>
        /// 技能认证
        /// </summary>
        [Description("技能认证")]
        Skill = 2
    }
}
