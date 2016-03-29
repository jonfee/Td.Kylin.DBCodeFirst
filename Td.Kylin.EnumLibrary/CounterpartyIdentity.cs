using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 交易对方身份
    /// </summary>
    public enum CounterpartyIdentity
    {
        /// <summary>
        /// 普通用户
        /// </summary>
        [Description("普通用户")]
        User =1,
        /// <summary>
        /// 服务人员
        /// </summary>
        [Description("服务人员")]
        Worker = 2,
        /// <summary>
        /// 商家
        /// </summary>
        [Description("商家")]
        Merchant = 4,
        /// <summary>
        /// 区域运营商
        /// </summary>
        [Description("区域运营商")]
        AreaOperator = 8,
        /// <summary>
        /// 系统平台
        /// </summary>
        [Description("系统平台")]
        Platform = 16
    }
}
