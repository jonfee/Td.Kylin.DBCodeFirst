using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 短信类型
    /// </summary>
    public enum SmsType
    {
        /// <summary>
        /// 注册
        /// </summary>
        [Description("注册")]
        Register = 1,
        /// <summary>
        /// 找回密码
        /// </summary>
        [Description("找回密码")]
        FindPassword = 2
    }
}
