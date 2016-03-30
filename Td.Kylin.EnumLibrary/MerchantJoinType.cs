

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 商户来源
    /// </summary>
    public enum MerchantJoinType
    {
        /// <summary>
        /// 商家注册
        /// </summary>
        [Description("商家注册")]
        Regist = 1,
        /// <summary>
        /// 资料收集
        /// </summary>
        [Description("资料收集")]
        Collection = 2,
        /// <summary>
        /// 后台录入
        /// </summary>
        [Description("后台录入")]
        Backatage = 4
    }
}
