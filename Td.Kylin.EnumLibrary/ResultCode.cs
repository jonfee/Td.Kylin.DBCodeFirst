using Td.Common;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    public static class EnumValue
    {
        /// <summary>
        /// 获取枚举值
        /// </summary>
        /// <param name="err"></param>
        /// <returns></returns>
        public static int GetEnumValue<T>(this T err)
        {
            return Converter.ConvertValue<int>(err);
        }
    }
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
        /// <summary>
        /// 接口异常统一返回
        /// </summary>
        [Description("接口异常统一返回")]
        Error = 1000,
        /// <summary>
        /// 数据连接失败
        /// </summary>
        [Description("数据连接失败")]
        Connection = 1001,
        /// <summary>
        /// 上传失败
        /// </summary>
        [Description("上传失败")]
        Upload = 1101,
        /// <summary>
        /// 商家未配置
        /// </summary>
        [Description("商家未配置")]
        NotConfig = 1102,

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
        /// 优惠卷不存在
        /// </summary>
        [Description("优惠卷不存在")]
        NotWelfare = 1108,
        /// <summary>
        /// 总金额不足以使用优惠卷
        /// </summary>
        [Description("总金额不足以使用优惠卷")]
        NotUseWelfare = 1109,

        /// <summary>
        /// 商家不存在
        /// </summary>
        [Description("商家不存在")]
        NotMerchant = 1110,
        /// <summary>
        /// 用户不存在
        /// </summary>
        [Description("用户不存在")]
        NotUser = 1111,
        /// <summary>
        /// 用户未设置支付密码
        /// </summary>
        [Description("用户未设置支付密码")]
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
    }
}
