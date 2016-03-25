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
        Shake = 1,
        /// <summary>
        /// 时间配置
        /// </summary>
        Time = 2,
        /// <summary>
        /// 消息模板
        /// </summary>
        Message = 4,
        /// <summary>
        /// 短信模板
        /// </summary>
        SMS = 8,
        /// <summary>
        /// 默认区域抽成配置
        /// </summary>
        AreaCommission = 16
    }

    /// <summary>
    /// 平台对区域抽成项
    /// </summary>
    public enum PlatformCommissionOption
    {
        /// <summary>
        /// B2C区域直营商城订单抽成
        /// </summary>
        B2COrder = 1,
        /// <summary>
        /// 区域对商户订单交易佣金后抽成
        /// </summary>
        AreaCommissionByMerchantOrder = 2
    }

    /// <summary>
    /// 区域(运营商)对区域内的交易抽成项
    /// </summary>
    public enum AreaCommissionOption
    {
        /// <summary>
        /// 商家商品订单抽成
        /// </summary>
        MerchantProductOrder = 1,
        /// <summary>
        /// 商家服务订单抽成
        /// </summary>
        MerchantServiceOrder = 2
    }

    /// <summary>
    /// 摇一摇配置项
    /// </summary>
    public enum GlobalShakeConfigOption
    {
        /// <summary>
        /// 每日可摇次数
        /// </summary>
        DayTimes = 1
    }

    /// <summary>
    /// 全局时间配置项
    /// </summary>
    public enum GlobalTimeConfigOption
    {
        /// <summary>
        /// 社区活动开始提醒时间
        /// </summary>
        CircleEventRemind = 1,
        /// <summary>
        /// 限时福利报名提醒时间
        /// </summary>
        WelfareApplyRemind = 2,
        /// <summary>
        /// B2C商城订单等待支付时间
        /// </summary>
        B2COrderWaitPayment = 3,
        /// <summary>
        /// B2C商城订单等待收货时间
        /// </summary>
        B2COrderWaitReceive = 4,
        /// <summary>
        /// B2C商城订单等待评价时间
        /// </summary>
        B2COrderEvaluate = 5,
        /// <summary>
        /// 商户商品订单等待支付时间
        /// </summary>
        MerchantOrderWaitPayment = 6,
        /// <summary>
        /// 商户商品订单等待收货时间
        /// </summary>
        MerchantOrderWaitReceive = 7,
        /// <summary>
        /// 商户商品订单等待评价时间
        /// </summary>
        MerchantOrderWaitEvaluate = 8,
        /// <summary>
        /// 上门预约服务等待支付时间
        /// </summary>
        ServiceOrderWaitPayment = 9,
        /// <summary>
        /// 上门预约服务等待用户完成时间
        /// </summary>
        ServiceOrderWaitUserDone = 10,
        /// <summary>
        /// 上门预约服务等待评价时间
        /// </summary>
        ServiceOrderWaitUserEvaluate = 11,
        /// <summary>
        /// 摇一摇商品下单后等待支付时间
        /// </summary>
        ShakeB2COrderWaitPayment = 12,
        /// <summary>
        /// 短信验证码有效时间
        /// </summary>
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
        FirstLogin = 1,
        /// <summary>
        /// 商家确认商品订单
        /// </summary>
        MerchantSureGoodsOrder = 2,
        /// <summary>
        /// 商家确认服务订单
        /// </summary>
        MerchantSureServiceOrder = 3,
        /// <summary>
        /// 商家取消商品订单
        /// </summary>
        MerchantCancelGoodsOrder = 4,
        /// <summary>
        /// 商家取消服务订单
        /// </summary>
        MerchantCancelServiceOrder = 5,
        /// <summary>
        /// 个人服务人员确认订单
        /// </summary>
        PersonalSureServiceOrder = 6,
        /// <summary>
        /// 超时未支付取消订单
        /// </summary>
        OrderPaymentTimeOut = 7,
        /// <summary>
        /// 接单提示
        /// </summary>
        OrderReceiving = 8,
        /// <summary>
        /// 上门预约订单即将开始提醒
        /// </summary>
        ServiceOrderBeforTime = 9,
        /// <summary>
        /// 余额支付成功扣款
        /// </summary>
        PaymentSuccess = 10,
        /// <summary>
        /// 取消订单退款成功
        /// </summary>
        OrderCancelAndBackMoneySuccess = 11,
        /// <summary>
        /// 社区活动即将开始
        /// </summary>
        CircleEventBefore = 12,
        /// <summary>
        /// 帖子被删除
        /// </summary>
        CircleTopicDeleted = 13,
        /// <summary>
        /// 帖子被置顶
        /// </summary>
        SetTopByCircleTopic = 14,
        /// <summary>
        /// 帖子取消置顶
        /// </summary>
        CancelTopByCircleTopic = 15,
        /// <summary>
        /// 帖子设为热帖
        /// </summary>
        SetHotByCircleTopic = 16,
        /// <summary>
        /// 帖子取消热帖
        /// </summary>
        CancelHotByCircleTopic = 17,
        /// <summary>
        /// 福利已结束
        /// </summary>
        WelfareFinish = 18,
        /// <summary>
        /// 用户等级提升
        /// </summary>
        UserLevelUpgrade = 19,
        /// <summary>
        /// 限时福利即将过期
        /// </summary>
        WelfareBeforLoseEfficacy = 20,
        /// <summary>
        /// 福利开奖提醒
        /// </summary>
        WelfareLottery = 21,
        /// <summary>
        /// 中奖
        /// </summary>
        WelfareWin = 22,
        /// <summary>
        /// 福利审核通过
        /// </summary>
        WelfareAuditSuccess = 23,
        /// <summary>
        /// 福利消费成功
        /// </summary>
        WelfareUsed = 24,
        /// <summary>
        /// 充值成功
        /// </summary>
        RechargeSuccess = 25,
        /// <summary>
        /// 提现成功
        /// </summary>
        WithdrawSuccess = 26,
        /// <summary>
        /// 抢单成功
        /// </summary>
        ServiceOrderGrabSuccess = 27,
        /// <summary>
        /// 抢单提示
        /// </summary>
        ServiceOrderGrabMessage = 28,
        /// <summary>
        /// 举报受理
        /// </summary>
        ComplaintsSuccess = 29,
        /// <summary>
        /// 反馈受理
        /// </summary>
        FeedbackSuccess = 30,
        /// <summary>
        /// 设为版主
        /// </summary>
        SetModerator = 31,
        /// <summary>
        /// 取消版主
        /// </summary>
        CancelModerator = 32,
        /// <summary>
        /// 用户认证成功
        /// </summary>
        UserCertificationSuccess = 33,
        /// <summary>
        /// 用户认证不成功
        /// </summary>
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
        Register = 1,
        /// <summary>
        /// 密码找回时发送验证码
        /// </summary>
        FindPassword = 2,
        /// <summary>
        /// 商户注册审核通过
        /// </summary>
        MerchantAuditSuccess = 3,
        /// <summary>
        /// 商户注册审核不通过
        /// </summary>
        MerchantAuditFailure = 4,
        /// <summary>
        /// 提现通知
        /// </summary>
        WithdrawNotice = 5,
        /// <summary>
        /// 服务开通业务申请成功
        /// </summary>
        ServiceBusinessOpenSuccess = 6,
        /// <summary>
        /// 服务开通业务申请不成功
        /// </summary>
        ServiceBusinessOpenFailure = 7

    }
}
