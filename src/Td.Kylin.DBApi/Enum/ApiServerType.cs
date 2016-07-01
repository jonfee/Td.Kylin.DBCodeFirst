using Td.ComponentModel;

namespace Td.Kylin.DBApi.Enum
{
    /// <summary>
    /// API服务类型
    /// </summary>
    public enum ApiServerType
    {
        /// <summary>
        /// 短信接口
        /// </summary>
        [Description("短信接口")]
        S0100,
        /// <summary>
        /// 消息推送接口
        /// </summary>
        [Description("消息推送接口")]
        S0200,
        /// <summary>
        /// 兴趣社区接口
        /// </summary>
        [Description("兴趣社区接口")]
        S0400,
        /// <summary>
        /// 精品汇商城接口
        /// </summary>
        [Description("精品汇商城接口")]
        S0500,
        /// <summary>
        /// 广告接口
        /// </summary>
        [Description("广告接口")]
        S0600,
        /// <summary>
        /// 招聘接口
        /// </summary>
        [Description("招聘接口")]
        S0700,
        /// <summary>
        /// 摇一摇接口
        /// </summary>
        [Description("摇一摇接口")]
        S0800,
        /// <summary>
        /// 限时福利接口
        /// </summary>
        [Description("限时福利接口")]
        S0900,
        /// <summary>
        /// 商家商品/服务接口
        /// </summary>
        [Description("商家商品/服务接口")]
        S1000,
        /// <summary>
        /// 上门预约接口
        /// </summary>
        [Description("上门预约接口")]
        S1100,
        /// <summary>
        /// 用户订单接口
        /// </summary>
        [Description("用户订单接口")]
        S1200,
        /// <summary>
        /// 企业增值服务商城接口
        /// </summary>
        [Description("企业增值服务商城接口")]
        S1300,
        /// <summary>
        /// 用户接口
        /// </summary>
        [Description("用户接口")]
        S1400,
        /// <summary>
        /// 商家接口
        /// </summary>
        [Description("商家接口")]
        S1500,
        /// <summary>
        /// 员工接口
        /// </summary>
        [Description("员工接口")]
        S1600,
        /// <summary>
        /// 系统综合服务接口
        /// </summary>
        [Description("系统综合服务接口")]
        S1700,
        /// <summary>
        /// 搜索接口
        /// </summary>
        [Description("搜索接口")]
        S1800,
        /// <summary>
        /// 配送接口
        /// </summary>
        [Description("配送接口")]
        S1900
    }

    public enum ApiModule
    {
        /// <summary>
        /// 系统服务端（不限系统）
        /// </summary>
        [Description("IOS 用户端")]
        V001,
        /// <summary>
        /// IM服务
        /// </summary>
        [Description("IM服务端")]
        T001,
        /// <summary>
        /// 定时任务服务
        /// </summary>
        [Description("定时任务服务端")]
        T002,
        /// <summary>
        /// 推送服务端
        /// </summary>
        [Description("推送服务端")]
        T003,
        /// <summary>
        /// 精选推送系统
        /// </summary>
        [Description("精选推送系统")]
        T004,
        /// <summary>
        /// 大后台
        /// </summary>
        [Description("大后台")]
        M100,
        /// <summary>
        /// 运营商后台
        /// </summary>
        [Description("运营商后台")]
        M200,
        /// <summary>
        /// 代理商后台
        /// </summary>
        [Description("代理商后台")]
        M300,
        /// <summary>
        /// IOS 用户端
        /// </summary>
        [Description("IOS 用户端")]
        U001,
        /// <summary>
        /// Android 用户端
        /// </summary>
        [Description("Android 用户端")]
        U002,
        /// <summary>
        /// WinPhone 用户端
        /// </summary>
        [Description("WinPhone 用户端")]
        U003,
        /// <summary>
        /// IOS 商户端
        /// </summary>
        [Description("IOS 商户端")]
        E001,
        /// <summary>
        /// Android 商户端
        /// </summary>
        [Description("Android 商户端")]
        E002,
        /// <summary>
        /// WinPhone 商户端
        /// </summary>
        [Description("WinPhone 商户端")]
        E003,
        /// <summary>
        /// IOS 工作端
        /// </summary>
        [Description("IOS 工作端")]
        F001,
        /// <summary>
        /// Android 工作端
        /// </summary>
        [Description("Android 工作端")]
        F002,
        /// <summary>
        /// WinPhone 工作端
        /// </summary>
        [Description("WinPhone 工作端")]
        F003
    }
}
