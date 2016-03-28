using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 学历
    /// </summary>
    public enum Education
    {
        /// <summary>
        /// 初中及以下
        /// </summary>
        [Description("初中及以下")]
        JuniorMiddle = 1,
        /// <summary>
        /// 高中
        /// </summary>
        [Description("高中")]
        SeniorHigh = 2,
        /// <summary>
        /// 大专
        /// </summary>
        [Description("大专")]
        JuniorCollege = 3,
        /// <summary>
        /// 本科
        /// </summary>
        [Description("本科")]
        BachelorDegree = 4,
        /// <summary>
        /// 硕士及以上
        /// </summary>
        [Description("硕士及以上")]
        MasterDegree = 5
    }
}
