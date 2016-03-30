using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 返回结果Code枚举
    /// </summary>
    public enum ResultCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        [Description("成功")]
        Success = 0,
        /// <summary>
        /// 参数缺失
        /// </summary>
        [Description("参数缺失")]
        ParametersMissing = 1,
        /// <summary>
        /// 参数不正确
        /// </summary>
        [Description("参数不正确")]
        ParametersError = 2,
        /// <summary>
        /// 请求已失效
        /// </summary>
        [Description("请求已失效")]
        RequestExpires = 3,
        /// <summary>
        /// 获取模块授权异常
        /// </summary>
        [Description("获取模块授权异常")]
        GetModuleException = 4,
        /// <summary>
        /// 授权失败
        /// </summary>
        [Description("授权失败")]
        AuthorizationFailed = 5,
        /// <summary>
        /// 数据异常
        /// </summary>
        [Description("数据异常")]
        DataException = 6,
        /// <summary>
        /// 签名异常
        /// </summary>
        [Description("签名异常")]
        SignException = 7,
        /// <summary>
        /// 请求模式无效
        /// </summary>
        [Description("请求模式无效")]
        RequestModeInvalid = 8,
        /// <summary>
        /// 非法请求10
        /// </summary>
        [Description("非法请求")]
        IllegalRequest = 9,

    }
}
