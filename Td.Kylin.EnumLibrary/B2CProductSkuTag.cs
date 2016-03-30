

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// B2C商品SKU标识
    /// </summary>
    public enum B2CProductSkuTag
    {
        /// <summary>
        /// 摇一摇申请中
        /// </summary>
        [Description("摇一摇申请中")]
        ShakeAuditing = 1,
        /// <summary>
        /// 摇一摇使用中
        /// </summary>
        [Description("摇一摇使用中")]
        ShakeUse = 2
    }
}
