using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.Common;
using Td.Kylin.Entity;
using Td.Kylin.EnumLibrary;

namespace Td.Kylin.DBApi.Data.SysData
{
    /// <summary>
    /// 全局配置数据
    /// </summary>
    public class GlobalConfig
    {
        static GlobalConfig()
        {
            _globalResources = null;
        }

        private static List<System_GlobalResources> _globalResources;

        public static List<System_GlobalResources> GlobalResources
        {
            get
            {
                if (null == _globalResources)
                {
                    InitConfig();
                }

                return _globalResources;
            }
        }


        static void InitConfig()
        {
            _globalResources = new List<System_GlobalResources>();

            //摇一摇配置
            AddShakeConfig();
            //时间配置
            AddTimeConfig();
            //默认区域抽成配置
            AddPlatformCommissionConfig();
            //消息模板配置
            AddMessageTemplateConfig();
            //短信模板配置
            AddSmsTemplateConfig();
        }

        /// <summary>
        /// 添加到全局配置项
        /// </summary>
        /// <param name="recourceType"></param>
        /// <param name="resourceKey"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="group"></param>
        /// <param name="valueUnit"></param>
        static void Add(int recourceType, int resourceKey, string name, string value, string group, int valueUnit)
        {
            _globalResources.Add(new System_GlobalResources
            {
                ResourceType = recourceType,
                ResourceKey = resourceKey,
                Name = name,
                Value = value,
                Group = group,
                ValueUnit = valueUnit,
                UpdateTime = DateTime.Now
            });
        }

        /// <summary>
        /// 添加摇一摇配置项
        /// </summary>
        static void AddShakeConfig()
        {
            var dic = EnumUtility.GetEnumDescriptions(typeof(GlobalShakeConfigOption));

            string group = "shake";
            int unit = 0;

            foreach (var kv in dic)
            {
                if (kv.Key == (int)GlobalShakeConfigOption.DayTimes)
                {
                    group = "次数";

                    Add((int)GlobalConfigType.Shake, kv.Key, kv.Value, "3", group, unit);
                }
            }
        }

        /// <summary>
        /// 添加时间配置项
        /// </summary>
        static void AddTimeConfig()
        {
            var dic = EnumUtility.GetEnumDescriptions(typeof(GlobalTimeConfigOption));

            string group = "time";
            int unit = (int)TimeOption.Hour;
            int value = 24;

            foreach (var kv in dic)
            {
                GlobalTimeConfigOption option = (GlobalTimeConfigOption)System.Enum.Parse(typeof(GlobalTimeConfigOption), kv.Key.ToString());

                switch (option)
                {
                    //B2C商城
                    case GlobalTimeConfigOption.B2COrderEvaluate: group = "B2C商城"; value = 168; break;
                    case GlobalTimeConfigOption.B2COrderWaitPayment: group = "B2C商城"; value = 72; break;
                    case GlobalTimeConfigOption.B2COrderWaitReceive: group = "B2C商城"; value = 168; break;
                    //商家商铺
                    case GlobalTimeConfigOption.MerchantOrderWaitEvaluate: group = "商家商铺"; value = 168; break;
                    case GlobalTimeConfigOption.MerchantOrderWaitPayment: group = "商家商铺"; value = 72; break;
                    case GlobalTimeConfigOption.MerchantOrderWaitReceive: group = "商家商铺"; value = 168; break;
                    //兴趣社区
                    case GlobalTimeConfigOption.CircleEventRemind: group = "兴趣社区"; value = 30; unit = (int)TimeOption.Minute; break;
                    //上门预约服务订单
                    case GlobalTimeConfigOption.ServiceOrderWaitPayment: group = "上门预约"; value = 24; break;
                    case GlobalTimeConfigOption.ServiceOrderWaitUserDone: group = "上门预约"; value = 72; break;
                    case GlobalTimeConfigOption.ServiceOrderWaitUserEvaluate: group = "上门预约"; value = 168; break;
                    //摇一摇
                    case GlobalTimeConfigOption.ShakeB2COrderWaitPayment: group = "摇一摇"; value = 30; unit = (int)TimeOption.Minute; break;
                    //短信验证码
                    case GlobalTimeConfigOption.SmsCode: group = "短信验证码"; value = 120; unit = (int)TimeOption.Second; break;
                    //限时福利
                    case GlobalTimeConfigOption.WelfareApplyRemind: group = "限时福利"; value = 30; unit = (int)TimeOption.Minute; break;
                }

                Add((int)GlobalConfigType.Time, kv.Key, kv.Value, value.ToString(), group, unit);
            }
        }

        /// <summary>
        /// 添加平台对区域默认抽成配置项
        /// </summary>
        static void AddPlatformCommissionConfig()
        {
            var dic = EnumUtility.GetEnumDescriptions(typeof(PlatformCommissionOption));

            string group = "commission";
            int unit = (int)CommissionType.MoneyRate;
            decimal value = 1M;

            foreach (var kv in dic)
            {
                PlatformCommissionOption option = (PlatformCommissionOption)System.Enum.Parse(typeof(PlatformCommissionOption), kv.Key.ToString());

                switch (option)
                {
                    //B2C商城
                    case PlatformCommissionOption.B2COrder: group = "B2C商城"; value = 1; unit = (int)CommissionType.MoneyRate; break;
                    //运营商对商家抽成后的佣金
                    case PlatformCommissionOption.AreaCommissionByMerchantOrder: group = "运营商对商家抽成后的佣金"; value = 10; unit = (int)CommissionType.MoneyRate; break;
                    //运营商对个人服务者抽成后的佣金
                    case PlatformCommissionOption.AreaCommissionByWorkerOrder: group = "运营商对个人服务者抽成后的佣金"; value = 10; unit = (int)CommissionType.MoneyRate; break;
                }

                Add((int)GlobalConfigType.AreaCommission, kv.Key, kv.Value, value.ToString(), group, unit);
            }
        }

        /// <summary>
        /// 添加消息模板配置项
        /// </summary>
        static void AddMessageTemplateConfig()
        {
            var dic = EnumUtility.GetEnumDescriptions(typeof(MessageTemplateOption));

            string group = "commission";
            int unit = 0;
            string value = null;

            foreach (var kv in dic)
            {
                MessageTemplateOption option = (MessageTemplateOption)System.Enum.Parse(typeof(MessageTemplateOption), kv.Key.ToString());

                switch (option)
                {
                    //兴趣社区
                    case MessageTemplateOption.CancelHotByCircleTopic: group = "兴趣社区"; value = "您好！您在“#ForumName#”的帖子“#TopicTitle#”#原因#被取消热帖,如有疑问联系#客服#!"; break;
                    case MessageTemplateOption.CancelModerator: group = "兴趣社区"; value = "您好！感谢您在版主任职期间的贡献，恭喜您光荣退休!"; break;
                    case MessageTemplateOption.CancelTopByCircleTopic: group = "兴趣社区"; value = "您好！您在“#ForumName#”的帖子“#TopicTitle#”#原因（到期/违规）#被取消置顶,如有疑问联系#客服#!"; break;
                    case MessageTemplateOption.CircleEventBefore: group = "兴趣社区"; value = "您报名的活动“#TopicTitle#”将在#EventTime#开始，请准时参加！"; break;
                    case MessageTemplateOption.CircleTopicDeleted: group = "兴趣社区"; value = "您好！您在“#ForumName#”的帖子“#TopicTitle#”#原因#被管理员删除,如有疑问联系#ServerPhone#!"; break;
                    case MessageTemplateOption.SetHotByCircleTopic: group = "兴趣社区"; value = "您好！您在“#ForumName#”的帖子“#TopicTitle#”被万众追捧，管理员已将您的帖子设为热帖万世流传，如有疑问联系#ServerPhone#！"; break;
                    case MessageTemplateOption.SetModerator: group = "兴趣社区"; value = "您好！由于您在#ForumName#中突出贡献，管理员已将您升为版主，如有疑问联系#ServerPhone#！"; break;
                    case MessageTemplateOption.SetTopByCircleTopic: group = "兴趣社区"; value = "您好！您在“#ForumName#”的帖子“#TopicTitle#”万中无一，管理员已将它置顶让万众瞻仰，如有疑问联系#ServerPhone#！"; break;
                    //反馈举报
                    case MessageTemplateOption.ComplaintsSuccess: group = "反馈举报"; value = "您好，您的举报信息已经受理，我们会跟进处理！"; break;
                    case MessageTemplateOption.FeedbackSuccess: group = "反馈举报"; value = "您好，您反馈的意见我们悉心接纳，期待我们的改变吧！"; break;
                    //登录注册
                    case MessageTemplateOption.FirstLogin: group = "登录注册"; value = "您好，欢迎加入小地方，#AreaName#自己的生活圈！"; break;
                    //订单
                    case MessageTemplateOption.MerchantCancelGoodsOrder: group = "订单"; value = "您好！您的商品订单#OrderCode#已被商家#MerchantName#残忍取消，如有疑问联系#MerchantPhone#！"; break;
                    case MessageTemplateOption.MerchantCancelServiceOrder: group = "订单"; value = "您好！您的服务订单#OrderCode#已被商家#MerchantName#残忍取消，如有疑问联系#MerchantPhone#！"; break;
                    case MessageTemplateOption.MerchantSureGoodsOrder: group = "订单"; value = "您好！您的商品订单#OrderCode#已被商家#MerchantName#飞速确认，如有疑问联系#MerchantPhone#！"; break;
                    case MessageTemplateOption.MerchantSureServiceOrder: group = "订单"; value = "您好！您的服务订单#OrderCode#已被商家#MerchantName#飞速确认，如有疑问联系#MerchantPhone#！"; break;
                    case MessageTemplateOption.OrderCancelAndBackMoneySuccess: group = "订单"; value = "您好！您的订单#OrderCode#退款金额#Amount#（#DateTime#）已退回钱包，如有疑问联系#ServerPhone#！"; break;
                    case MessageTemplateOption.OrderPaymentTimeOut: group = "订单"; value = "您好！由于您长时间未支付，订单#OrderCode#已被关闭，如有疑问联系#ServerPhone#！"; break;
                    case MessageTemplateOption.OrderReceiving: group = "订单"; value = "快来接单，有单来了！"; break;
                    case MessageTemplateOption.PaymentSuccess: group = "订单"; value = "您好！您的订单#OrderCode#成功支付#Amount#，如有疑问联系#MerchantPhone#！"; break;
                    case MessageTemplateOption.PersonalSureServiceOrder: group = "订单"; value = "您好！您的服务订单#OrderCode#已被#Worker#飞速确认，如有疑问联系#WorkerPhone#！"; break;
                    case MessageTemplateOption.RechargeSuccess: group = "订单"; value = "您好！您在#DateTime#成功充值#Amount#，如有疑问联系#ServerPhone#"; break;
                    case MessageTemplateOption.ServiceOrderBeforTime: group = "订单"; value = "您好！您的服务订单#OrderCode#即将开始，请准时到达提供服务！"; break;
                    case MessageTemplateOption.ServiceOrderGrabMessage: group = "订单"; value = "有单来了，快抢快抢！"; break;
                    case MessageTemplateOption.ServiceOrderGrabSuccess: group = "订单"; value = "手速如我，谁与争锋，抢单就是这么简单！订单编号#OrderCode#"; break;
                    //认证
                    case MessageTemplateOption.UserCertificationFailure: group = "认证"; value = "您好！由于#Reason#客服未通过您的实名认证信息，请调整后再次提交，如有疑问联系#SererPhone#！"; break;
                    case MessageTemplateOption.UserCertificationSuccess: group = "认证"; value = "您好！您的实名认证信息已通过审核，如有疑问联系#ServerPhone#！"; break;
                    //积分等级
                    case MessageTemplateOption.UserLevelUpgrade: group = "积分等级"; value = "通过不懈努力，您的等级已突破#LevelName#，系统排名上升#Number#，#LevelRemark#！"; break;
                    //限时福利
                    case MessageTemplateOption.WelfareAuditSuccess: group = "限时福利"; value = "您好！您申请的福利(#WelfareName#)，客服在#DateTime#已经审核通过，如有疑问联系#ServerPhone#！"; break;
                    case MessageTemplateOption.WelfareBeforLoseEfficacy: group = "限时福利"; value = "您好！您的福利#WelfareName#即将过期，再不用它就要离家出走了！"; break;
                    case MessageTemplateOption.WelfareFinish: group = "限时福利"; value = "您好！你参与的福利#WelfareName#已开奖，如有疑问联系#ServerPhone#！"; break;
                    case MessageTemplateOption.WelfareLottery: group = "限时福利"; value = "您好！您参与的福利#WelfareName#即将开奖，幸运的小伙伴会不会是你呢?"; break;
                    case MessageTemplateOption.WelfareUsed: group = "限时福利"; value = "您好！您的福利(#WelfareName#)于#DateTime#在#MerchantName#消费成功，如有疑问联系#MerchantPhone#！"; break;
                    case MessageTemplateOption.WelfareWin: group = "限时福利"; value = "有福咯！鸿运当头，您已抽中#WelfareName#，记得在有效期内领取消费哟！"; break;
                    //申请提现成功
                    case MessageTemplateOption.WithdrawSuccess: group = "限时福利"; value = "您好！您在#DateTime#发起#Amount#提现成功，预计将在#DateTime#到账，如有疑问联系#ServerPhone#！"; break;
                }

                Add((int)GlobalConfigType.Message, kv.Key, kv.Value, value.ToString(), group, unit);
            }
        }

        /// <summary>
        /// 添加短信模板配置项
        /// </summary>
        static void AddSmsTemplateConfig()
        {
            var dic = EnumUtility.GetEnumDescriptions(typeof(SmsTemplateOption));

            string group = "commission";
            int unit = 0;
            string value = null;

            foreach (var kv in dic)
            {
                SmsTemplateOption option = (SmsTemplateOption)System.Enum.Parse(typeof(SmsTemplateOption), kv.Key.ToString());

                switch (option)
                {
                    //登录注册
                    case SmsTemplateOption.FindPassword: group = "登录注册"; value = "【#AppName#】您的验证码为：#Code#（工作人员绝不会索取此验证码），如有疑问联系#ServerPhone#！"; break;
                    case SmsTemplateOption.Register: group = "登录注册"; value = "【#AppName#】您的验证码为：#数字#（#软件名#客服绝不会索取此验证码），如有疑问联系#ServerPhone#！"; break;
                    //认证审核
                    case SmsTemplateOption.MerchantAuditFailure: group = "认证审核"; value = "【#AppName#】您好！由于#审核不成功原因#客服未通过您的店铺开通信息，请调整后再次提交，如有疑问联系#ServerPhone#！"; break;
                    case SmsTemplateOption.MerchantAuditSuccess: group = "认证审核"; value = "【#AppName#】您好！您的店铺开通信息已通过审核，如有疑问联系#ServerPhone#！"; break;
                    //业务申请审核
                    case SmsTemplateOption.ServiceBusinessOpenFailure: group = "业务申请审核"; value = "【#AppName#】您好！由于#审核不成功原因#客服未通过您的开通业务申请，请调整后再次提交，如有疑问联系#ServerPhone#！"; break;
                    case SmsTemplateOption.ServiceBusinessOpenSuccess: group = "业务申请审核"; value = "【#AppName#】您好！您的开通业务申请已通过审核，如有疑问联系#ServerPhone#！"; break;
                    //通知
                    case SmsTemplateOption.WithdrawNotice: group = "提现通知"; value = "【#AppName#】您好！您在#DateTime#发起#Amount#提现成功，预计将在#DateTime#到账，如有疑问联系#ServerPhone#！"; break;
                }

                Add((int)GlobalConfigType.SMS, kv.Key, kv.Value, value.ToString(), group, unit);
            }
        }
    }
}
