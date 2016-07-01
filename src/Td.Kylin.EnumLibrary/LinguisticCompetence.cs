

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 语言能力
    /// </summary>
    public enum LinguisticCompetence
    {
        /// <summary>
        /// 一般
        /// </summary>
        [Description("一般")]
        General = 1,
        /// <summary>
        /// 良好
        /// </summary>
        [Description("良好")]
        Nice = 2,
        /// <summary>
        /// 熟练
        /// </summary>
        [Description("熟练")]
        Skillful = 4,
        /// <summary>
        /// 精通
        /// </summary>
        [Description("精通")]
        Proficiency =8
    }
}
