

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 商家服务产品状态
    /// </summary>
    public enum MerchantServiceProductStatus
    {
        /// <summary>
        /// 上架中
        /// </summary>
        [Description("上架中")]
        OnSale = 1,
        /// <summary>
        /// 已下架
        /// </summary>
        [Description("已下架")]
        UnShelve = 2
    }
}
