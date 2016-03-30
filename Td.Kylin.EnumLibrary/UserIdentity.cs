

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 用户身份
    /// </summary>
    public enum UserIdentity
    {
        /// <summary>
        /// 普通用户
        /// </summary>
        [Description("普通用户")]
        DefaultUser = 1,
        /// <summary>
        /// 企业职员
        /// </summary>
        [Description("企业职员")]
        CompanyEmployee = 2,
        /// <summary>
        /// 个人服务者
        /// </summary>
        [Description("个人服务者")]
        PersonalService = 4,
        /// <summary>
        /// 配送员
        /// </summary>
        [Description("配送员")]
        Diliveryman = 8
    }
}
