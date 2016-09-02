using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 区域协议配置类型枚举
    /// </summary>
    public enum AreaProtocolType
    {
        /// <summary>
        /// 商家注册协议
        /// </summary>
        [Description("商家注册协议")]
        MerchantRegist = 1,
        /// <summary>
        /// 跑腿业务申请协议
        /// </summary>
        [Description("跑腿业务申请协议")]
        ApplyForLegworkBusiness = 2
    }
}
