using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// B2C商品销售状态
    /// </summary>
    public enum B2CProductSaleStatus
    {
        /// <summary>
        /// 销售中
        /// </summary>
        [Description("销售中")]
        OnSale = 1,
        /// <summary>
        /// 已下架
        /// </summary>
        [Description("已下架")]
        UnShelve = 2
    }
}
