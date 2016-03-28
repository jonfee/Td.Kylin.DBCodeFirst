using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 商城类型
    /// </summary>
    public enum MallType
    {
        /// <summary>
        /// B2C区域直营
        /// </summary>
        [Description("B2C区域直营")]
        B2C =1,
        /// <summary>
        /// 企业微商城
        /// </summary>
        [Description("企业微商城")]
        Merchant =2
    }
}
