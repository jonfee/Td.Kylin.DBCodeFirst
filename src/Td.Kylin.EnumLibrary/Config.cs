

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 全局配置类型
    /// </summary>
    public enum GlobalConfigType
    {
        /// <summary>
        /// 摇一摇配置
        /// </summary>
        [Description("摇一摇配置")]
        Shake = 1,
        /// <summary>
        /// 时间配置
        /// </summary>
        [Description("时间配置")]
        Time = 2,
        /// <summary>
        /// 消息模板
        /// </summary>
        [Description("消息模板")]
        Message = 4,
        /// <summary>
        /// 短信模板
        /// </summary>
        [Description("短信模板")]
        SMS = 8,
        /// <summary>
        /// 区域抽成默认配置
        /// </summary>
        [Description("区域抽成默认配置")]
        AreaCommission = 16
    }

    /// <summary>
    /// 平台对区域抽成项
    /// </summary>
    public enum PlatformCommissionOption
    {
        /// <summary>
        /// 运营商订单抽成
        /// </summary>
        [Description("运营商订单抽成")]
        B2COrder = 1,
        /// <summary>
        /// 商户订单交易佣金抽成
        /// </summary>
        [Description("商户订单交易佣金抽成")]
        AreaCommissionByMerchantOrder = 2,
        /// <summary>
        /// 个人服务者订单交易佣金抽成
        /// </summary>
        [Description("个人服务者订单交易佣金抽成")]
        AreaCommissionByWorkerOrder = 4
    }

    /// <summary>
    /// 区域(运营商)对区域内默认的交易抽成项
    /// </summary>
    public enum AreaDefaultCommissionOption
    {
        /// <summary>
        /// 商家商品订单抽成
        /// </summary>
        [Description("商家商品订单抽成")]
        MerchantProductOrder = 1,
        /// <summary>
        /// 商家上门预约服务订单抽成
        /// </summary>
        [Description("商家上门预约服务订单抽成")]
        MerchantServiceOrder = 2,
        /// <summary>
        /// 个人服务者上门预约服务订单抽成
        /// </summary>
        [Description("个人服务者上门预约服务订单抽成")]
        WorkerServiceOrder = 4
    }

    /// <summary>
    /// 区域(运营商)对区域内商家的交易抽成项
    /// </summary>
    public enum AreaMerchantCommissionOption
    {
        /// <summary>
        /// 商家商品订单抽成
        /// </summary>
        [Description("商家商品订单抽成")]
        MerchantProductOrder = 1,
        /// <summary>
        /// 商家上门预约服务订单抽成
        /// </summary>
        [Description("商家上门预约服务订单抽成")]
        MerchantServiceOrder = 2
    }


    /// <summary>
    /// 区域(运营商)对区域内工作人员的交易抽成项
    /// </summary>
    public enum AreaWorkerCommissionOption
    {
        /// <summary>
        /// 上门预约服务订单抽成
        /// </summary>
        [Description("上门预约服务订单抽成")]
        WorkerServiceOrder = 2
    }

    /// <summary>
    /// 摇一摇配置项
    /// </summary>
    public enum GlobalShakeConfigOption
    {
        /// <summary>
        /// 每日可摇次数
        /// </summary>
        [Description("每日可摇次数")]
        DayTimes = 1
    }

    /// <summary>
    /// 全局时间配置项
    /// </summary>
    public enum GlobalTimeConfigOption
    {
        /// <summary>
        /// 社区活动开始时间提醒
        /// </summary>
        [Description("社区活动开始时间提醒")]
        CircleEventRemind = 1,
        /// <summary>
        /// 限时福利报名时间提醒
        /// </summary>
        [Description("限时福利报名时间提醒")]
        WelfareApplyRemind = 2,
        /// <summary>
        /// 运营商订单支付有效时间
        /// </summary>
        [Description("运营商订单支付有效时间")]
        B2COrderWaitPayment = 3,
        /// <summary>
        /// 运营商订单自动确认收货时间
        /// </summary>
        [Description("运营商订单自动确认收货时间")]
        B2COrderWaitReceive = 4,
        /// <summary>
        /// 运营商订单自动评价时间
        /// </summary>
        [Description("运营商订单自动评价时间")]
        B2COrderEvaluate = 5,
        /// <summary>
        /// 商户商品订单支付有效时间
        /// </summary>
        [Description("商户商品订单支付有效时间")]
        MerchantOrderWaitPayment = 6,
        /// <summary>
        /// 商户商品订单自动确认收货时间
        /// </summary>
        [Description("商户商品订单自动确认收货时间")]
        MerchantOrderWaitReceive = 7,
        /// <summary>
        /// 商户商品订单自动评价时间
        /// </summary>
        [Description("商户商品订单自动评价时间")]
        MerchantOrderWaitEvaluate = 8,
        /// <summary>
        /// 商家服务订单支付有效时间
        /// </summary>
        [Description("商家服务订单支付有效时间")]
        ServiceOrderWaitPayment = 9,
        /// <summary>
        /// 商家服务订单自动确认完成时间
        /// </summary>
        [Description("商家服务订单自动确认完成时间")]
        ServiceOrderWaitUserDone = 10,
        /// <summary>
        /// 商家服务订单自动评价时间
        /// </summary>
        [Description("商家服务订单自动评价时间")]
        ServiceOrderWaitUserEvaluate = 11,
        /// <summary>
        /// 摇一摇商品订单支付有效时间
        /// </summary>
        [Description("摇一摇商品订单支付有效时间")]
        ShakeB2COrderWaitPayment = 12,
        /// <summary>
        /// 短信验证码有效时间
        /// </summary>
        [Description("短信验证码有效时间")]
        SmsCode = 13
    }

    /// <summary>
    /// 系统消息模板配置项
    /// </summary>
    public enum MessageTemplateOption
    {
        /// <summary>
        /// 注册成功
        /// </summary>
        [Description("注册成功")]
        RegistrationSuccessful = 1,
        /// <summary>
        /// 邀请好友注册成功
        /// </summary>
        [Description("邀请好友注册成功")]
        InviteRegistrationSuccessful = 2,
        /// <summary>
        /// 实名认证审核通过
        /// </summary>
        [Description("实名认证审核通过")]
        RealNameCertificateSuccessful = 3,
        /// <summary>
        /// 实名认证审核失败
        /// </summary>
        [Description("实名认证审核失败")]
        RealNameCertificateFailure = 4,
        /// <summary>
        /// 申请跑腿业务审核成功
        /// </summary>
        [Description("申请跑腿业务审核成功")]
        WorkerLegworkBusinessApplySuccessful = 5,
        /// <summary>
        /// 申请跑腿业务审核失败
        /// </summary>
        [Description("申请跑腿业务审核失败")]
        WorkerLegworkBusinessApplyFailure = 6,
        /// <summary>
        /// 等级提升
        /// </summary>
        [Description("等级提升")]
        UserLevelUp = 7,
        /// <summary>
        /// 成为社区版主
        /// </summary>
        [Description("成为社区版主")]
        BecomeModerator = 8,
        /// <summary>
        /// 被取消版主
        /// </summary>
        [Description("被取消版主")]
        CancelModerator = 9
    }

    /// <summary>
    /// 短信模板配置项
    /// </summary>
    public enum SmsTemplateOption
    {
        /// <summary>
        /// 注册验证码
        /// </summary>
        [Description("注册验证码")]
        RegisterValidateCode = 1,
        /// <summary>
        /// 找回密码验证码
        /// </summary>
        [Description("找回密码验证码")]
        FindPasswordValidateCode = 2,
        /// <summary>
        /// 新订单通知
        /// </summary>
        [Description("新订单通知")]
        NewOrderNotice = 3,
        /// <summary>
        /// 跑腿业务申请通知
        /// </summary>
        [Description("跑腿业务申请通知")]
        WorkerLegworkBussinessApplyNotice = 4,
        /// <summary>
        /// 库存预警通知
        /// </summary>
        [Description("库存预警通知")]
        ProductInventoryWarningNotice = 5,
        /// <summary>
        /// 直营订单派送通知
        /// </summary>
        [Description("直营订单派送通知")]
        MallOrderDispachNotice = 6
    }

    /// <summary>
    /// 推送消息模板配置项
    /// </summary>
    public enum PushTemplateOption
    {
        /// <summary>
        /// 帖子被置顶
        /// </summary>
        [Description("帖子被置顶")]
        TopicTop = 1,
        /// <summary>
        /// 实名认证审核成功
        /// </summary>
        [Description("实名认证审核成功")]
        RealNameCertificateSuccessful = 2,
        /// <summary>
        /// 实名认证审核失败
        /// </summary>
        [Description("实名认证审核失败")]
        RealNameCertificateFailure = 3,
        /// <summary>
        /// 申请跑腿业务审核成功
        /// </summary>
        [Description("申请跑腿业务审核成功")]
        WorkerLegworkBusinessApplySuccessful = 4,
        /// <summary>
        /// 申请跑腿业务审核失败
        /// </summary>
        [Description("申请跑腿业务审核失败")]
        WorkerLegworkBusinessApplyFailure = 5,
        /// <summary>
        /// 直营订单已发货通知
        /// </summary>
        [Description("直营订单已发货通知")]
        MallOrderShipments = 6,
        /// <summary>
        /// 跑腿订单已完成送达
        /// </summary>
        [Description("跑腿订单已完成送达")]
        WorkerLegworkDelivered = 7,
        /// <summary>
        /// 运营商取消订单
        /// </summary>
        [Description("运营商取消订单")]
        OperatorCancelOrder = 8,
        /// <summary>
        /// 直营订单派送通知
        /// </summary>
        [Description("直营订单派送通知")]
        MallOrderDispachNotice = 9,
        /// <summary>
        /// 跑腿订单抢单推送
        /// </summary>
        [Description("跑腿订单抢单推送")]
        LegworkOrderGrab = 10,
        /// <summary>
        /// 跑腿订单报价
        /// </summary>
        [Description("跑腿订单报价")]
        LegworkOrderQuotePrice = 11,
        /// <summary>
        /// 用户完成跑腿订单
        /// </summary>
        [Description("用户完成跑腿订单")]
        UserDoneLegworkOrder = 12,
        /// <summary>
        /// 新直营订单通知
        /// </summary>
        [Description("新直营订单通知")]
        NewMallOrderNotice = 13
    }
}
