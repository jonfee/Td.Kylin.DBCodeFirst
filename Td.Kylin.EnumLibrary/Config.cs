

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
    /// 消息模板配置项
    /// </summary>
    public enum MessageTemplateOption
    {
        /// <summary>
        /// 首次登录
        /// </summary>
        [Description("首次登录")]
        FirstLogin = 1,
        /// <summary>
        /// 商家确认商品订单
        /// </summary>
        [Description("商家确认商品订单")]
        MerchantSureGoodsOrder = 2,
        /// <summary>
        /// 商家确认服务订单
        /// </summary>
        [Description("商家确认服务订单")]
        MerchantSureServiceOrder = 3,
        /// <summary>
        /// 商家取消商品订单
        /// </summary>
        [Description("商家取消商品订单")]
        MerchantCancelGoodsOrder = 4,
        /// <summary>
        /// 商家取消服务订单
        /// </summary>
        [Description("商家取消服务订单")]
        MerchantCancelServiceOrder = 5,
        /// <summary>
        /// 本地服务人员确认订单
        /// </summary>
        [Description("本地服务人员确认订单")]
        PersonalSureServiceOrder = 6,
        /// <summary>
        /// 超时未支付取消订单
        /// </summary>
        [Description("超时未支付取消订单")]
        OrderPaymentTimeOut = 7,
        /// <summary>
        /// 接单提示
        /// </summary>
        [Description("接单提示")]
        OrderReceiving = 8,
        /// <summary>
        /// 商家服务订单即将开始提醒
        /// </summary>
        [Description("商家服务订单即将开始提醒")]
        ServiceOrderBeforTime = 9,
        /// <summary>
        /// 余额支付成功扣款
        /// </summary>
        [Description("余额支付成功扣款")]
        PaymentSuccess = 10,
        /// <summary>
        /// 取消订单退款成功
        /// </summary>
        [Description("取消订单退款成功")]
        OrderCancelAndBackMoneySuccess = 11,
        /// <summary>
        /// 社区活动即将开始
        /// </summary>
        [Description("社区活动即将开始")]
        CircleEventBefore = 12,
        /// <summary>
        /// 帖子被删除
        /// </summary>
        [Description("帖子被删除")]
        CircleTopicDeleted = 13,
        /// <summary>
        /// 帖子被置顶
        /// </summary>
        [Description("帖子被置顶")]
        SetTopByCircleTopic = 14,
        /// <summary>
        /// 帖子取消置顶
        /// </summary>
        [Description("帖子取消置顶")]
        CancelTopByCircleTopic = 15,
        /// <summary>
        /// 帖子设为热帖
        /// </summary>
        [Description("帖子设为热帖")]
        SetHotByCircleTopic = 16,
        /// <summary>
        /// 帖子取消热帖
        /// </summary>
        [Description("帖子取消热帖")]
        CancelHotByCircleTopic = 17,
        /// <summary>
        /// 福利已结束
        /// </summary>
        [Description("福利已结束")]
        WelfareFinish = 18,
        /// <summary>
        /// 用户等级提升
        /// </summary>
        [Description("用户等级提升")]
        UserLevelUpgrade = 19,
        /// <summary>
        /// 限时福利即将过期
        /// </summary>
        [Description("限时福利即将过期")]
        WelfareBeforLoseEfficacy = 20,
        /// <summary>
        /// 福利开奖提醒
        /// </summary>
        [Description("福利开奖提醒")]
        WelfareLottery = 21,
        /// <summary>
        /// 用户中奖提醒
        /// </summary>
        [Description("用户中奖提醒")]
        WelfareWin = 22,
        /// <summary>
        /// 福利审核通过
        /// </summary>
        [Description("福利审核通过")]
        WelfareAuditSuccess = 23,
        /// <summary>
        /// 福利消费成功
        /// </summary>
        [Description("福利消费成功")]
        WelfareUsed = 24,
        /// <summary>
        /// 充值成功
        /// </summary>
        [Description("充值成功")]
        RechargeSuccess = 25,
        /// <summary>
        /// 提现成功
        /// </summary>
        [Description("提现成功")]
        WithdrawSuccess = 26,
        /// <summary>
        /// 抢单成功
        /// </summary>
        [Description("抢单成功")]
        ServiceOrderGrabSuccess = 27,
        /// <summary>
        /// 抢单提示
        /// </summary>
        [Description("抢单提示")]
        ServiceOrderGrabMessage = 28,
        /// <summary>
        /// 举报受理
        /// </summary>
        [Description("举报受理")]
        ComplaintsSuccess = 29,
        /// <summary>
        /// 反馈受理
        /// </summary>
        [Description("反馈受理")]
        FeedbackSuccess = 30,
        /// <summary>
        /// 设为版主
        /// </summary>
        [Description("设为版主")]
        SetModerator = 31,
        /// <summary>
        /// 取消版主
        /// </summary>
        [Description("取消版主")]
        CancelModerator = 32,
        /// <summary>
        /// 用户认证成功
        /// </summary>
        [Description("用户认证成功")]
        UserCertificationSuccess = 33,
        /// <summary>
        /// 用户认证不成功
        /// </summary>
        [Description("用户认证不成功")]
        UserCertificationFailure = 34
    }

    /// <summary>
    /// 短信模板配置项
    /// </summary>
    public enum SmsTemplateOption
    {
        /// <summary>
        /// 注册时发送验证码
        /// </summary>
        [Description("注册时发送验证码")]
        Register = 1,
        /// <summary>
        /// 密码找回时发送验证码
        /// </summary>
        [Description("密码找回时发送验证码")]
        FindPassword = 2,
        /// <summary>
        /// 商户注册审核通过
        /// </summary>
        [Description("商户注册审核通过")]
        MerchantAuditSuccess = 3,
        /// <summary>
        /// 商户注册审核不通过
        /// </summary>
        [Description("商户注册审核不通过")]
        MerchantAuditFailure = 4,
        /// <summary>
        /// 提现通知
        /// </summary>
        [Description("提现通知")]
        WithdrawNotice = 5,
        /// <summary>
        /// 服务开通业务申请成功
        /// </summary>
        [Description("服务开通业务申请成功")]
        ServiceBusinessOpenSuccess = 6,
        /// <summary>
        /// 服务开通业务申请不成功
        /// </summary>
        [Description("服务开通业务申请不成功")]
        ServiceBusinessOpenFailure = 7

    }
}
