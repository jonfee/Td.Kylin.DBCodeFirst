using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// B2C评价等级
    /// </summary>
    public enum B2CEvaluateLevel
    {
        /// <summary>
        /// 不满意
        /// </summary>
        [Description("不满意")]
        Dissatisfaction = 1,
        /// <summary>
        /// 一般
        /// </summary>
        [Description("一般")]
        General =2,
        /// <summary>
        /// 还行
        /// </summary>
        [Description("还行")]
        NotTooBad =3,
        /// <summary>
        /// 满意
        /// </summary>
        [Description("满意")]
        Satisfaction =4,
        /// <summary>
        /// 非常满意
        /// </summary>
        [Description("非常满意")]
        VerySatisfaction =5
    }
}
