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
    public enum ShakeConfigOption
    {
        /// <summary>
        /// 每日可摇次数
        /// </summary>
        DayTimes = 1
    }

    /// <summary>
    /// 全局时间配置项
    /// </summary>
    public enum TimeConfigOption
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
}
