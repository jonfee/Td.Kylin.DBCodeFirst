using Td.Common;
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
        /// 非法请求
        /// </summary>
        [Description("非法请求")]
        IllegalRequest = 9,
        /// <summary>
        /// 数据不存在或已被删除
        /// </summary>
        [Description("数据不存在或已被删除")]
        DataNoFound = 10,
        /// <summary>
        /// 数据存在但无法正常使用
        /// </summary>
        [Description("数据存在但无法正常使用")]
        DataDisabled = 11,
        /// <summary>
        /// 失败
        /// </summary>
        Failure = 40,
        /// <summary>
        /// 接口异常统一返回
        /// </summary>
        [Description("接口异常统一返回")]
        Error = 1000,
        /// <summary>
        /// 数据连接失败
        /// </summary>
        [Description("数据连接失败")]
        ConnectionFailure = 1001,
        /// <summary>
        /// 文件上传失败
        /// </summary>
        [Description("文件上传失败")]
        UploadFailure = 1101,
        /// <summary>
        /// 订单上级状态与当前修改状态不匹配
        /// </summary>
        [Description("订单上级状态与当前修改状态不匹配")]
        OrderStatusError = 1103,
        /// <summary>
        /// B2C-前端数据传输价格计算错误
        /// </summary>
        [Description("B2C-前端数据传输价格计算错误")]
        B2CFrontErrorOrderMoney = 1104,
        /// <summary>
        /// B2C-前端传入总价格与后台计算价格不符合
        /// </summary>
        [Description("B2C-前端传入总价格与后台计算价格不符合")]
        B2CBackErrorOrderMoney = 1105,
        /// <summary>
        /// 商家-前端数据传输价格计算错误
        /// </summary>
        [Description("商家-前端数据传输价格计算错误")]
        MerchantFrontErrorOrderMoney = 1106,
        /// <summary>
        /// 商家-前端传入总价格与后台计算价格不符合
        /// </summary>
        [Description("商家-前端传入总价格与后台计算价格不符合")]
        MerchantBackErrorOrderMoney = 1107,
        /// <summary>
        /// 未满足优惠券使用条件
        /// </summary>
        [Description("未满足优惠券使用条件")]
        NotUseWelfare = 1109,
        /// <summary>
        /// 未设置支付密码
        /// </summary>
        [Description("未设置支付密码")]
        NotPayPassword = 1112,
        /// <summary>
        /// 支付密码错误
        /// </summary>
        [Description("支付密码错误")]
        ErrorPayPassword = 1113,
        /// <summary>
        /// 余额不足
        /// </summary>
        [Description("余额不足")]
        BalanceDeficiency = 1114,
        /// <summary>
        /// 数据存在依赖性不允许删除
        /// </summary>
        [Description("数据存在依赖性不允许删除")]
        DeleteError = 1115
    }
}
