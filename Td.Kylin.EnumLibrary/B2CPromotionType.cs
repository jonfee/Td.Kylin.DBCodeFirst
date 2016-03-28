using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// B2C促销类型
    /// </summary>
    public enum B2CPromotionType
    {
        /// <summary>
        /// 直降
        /// </summary>
        [Description("直降")]
        Plummet = 1,
        /// <summary>
        /// 满减
        /// </summary>
        [Description("满减")]
        AfterReduction = 2
    }
}
