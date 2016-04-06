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
    }
    /// <summary>
    /// 商家------错误码区间：1101-1200
    /// </summary>
    public enum MerchantCode
    {
        /// <summary>
        /// 上传失败
        /// </summary>
        Upload = 1101,
        /// <summary>
        /// 商家未配置
        /// </summary>
        NotConfig = 1102,
        /// <summary>
        /// 附近没有商家
        /// </summary>
        NotMerchant = 1103,
    }
    /// <summary>
    /// 订单------错误码区间：1201-1300
    /// </summary>
    public enum OrderCode
    {
        /// <summary>
        /// 订单上级状态与当前修改状态不匹配
        /// </summary>
        OrderStatusError = 1201,
        /// <summary>
        /// B2C-前端数据传输价格计算错误
        /// </summary>
        B2CFrontErrorOrderMoney = 1202,
        /// <summary>
        /// B2C-前端传入总价格与后台计算价格不符合
        /// </summary>
        B2CBackErrorOrderMoney = 1203,
        /// <summary>
        /// 商家-前端数据传输价格计算错误
        /// </summary>
        MerchantFrontErrorOrderMoney = 1204,
        /// <summary>
        /// 商家-前端传入总价格与后台计算价格不符合
        /// </summary>
        MerchantBackErrorOrderMoney = 1205,
        /// <summary>
        /// 优惠卷不存在
        /// </summary>
        NotWelfare = 1206,
        /// <summary>
        /// 总金额不足以使用优惠卷
        /// </summary>
        NotUseWelfare = 1207,
    }
    /// <summary>
    /// 商家商品项目 1301-1400
    /// </summary>
    public enum MicroMallCode
    {

    }
    /// <summary>
    /// 上门预约项目 1401-1500
    /// </summary>
    public enum AppointCode
    {

    }
    /// <summary>
    /// 用户项目 1501-1600
    /// </summary>
    public enum UserCode
    {
        /// <summary>
        /// 商家不存在
        /// </summary>
        [Description("商家不存在")]
        NotMerchant = 1501,
        /// <summary>
        /// 用户不存在
        /// </summary>
        [Description("用户不存在")]
        NotUser = 1502,
        /// <summary>
        /// 用户未设置支付密码
        /// </summary>
        [Description("用户未设置支付密码")]
        NotPayPassword = 1503,
        /// <summary>
        /// 支付密码错误
        /// </summary>
        [Description("支付密码错误")]
        ErrorPayPassword = 1504,
        /// <summary>
        /// 余额不足
        /// </summary>
        [Description("余额不足")]
        BalanceDeficiency = 1505,
    }
    /// <summary>
    /// 社区项目 1601-1700
    /// </summary>
    public enum ForumsCode
    {

    }
    /// <summary>
    /// 员工项目 1701-1800
    /// </summary>
    public enum WorderCode
    {

    }
    /// <summary>
    /// 招聘项目 1801-1900
    /// </summary>
    public enum JobCode
    {

    }
    /// <summary>
    /// 摇一摇项目 1901-2000
    /// </summary>
    public enum ShakeCode
    {

    }
    /// <summary>
    /// 限时福利项目 2001-2100
    /// </summary>
    public enum WelfareCode
    {

    }

}
