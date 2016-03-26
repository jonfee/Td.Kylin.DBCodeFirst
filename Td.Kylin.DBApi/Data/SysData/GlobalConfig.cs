using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.Common;
using Td.Kylin.Entity;
using Td.Kylin.EnumLibrary;

namespace Td.Kylin.DBApi.Data.SysData
{
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
                if(null== _globalResources)
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
                    case MessageTemplateOption.CancelHotByCircleTopic: group = "兴趣社区"; value = "很遗憾的通知您,您在“#ForumName#”的帖子“#TopicTitle#”被取消热帖,不要伤心,么么哒!"; break;
                    case MessageTemplateOption.CancelModerator: group = "兴趣社区"; value = "很遗憾的通知您,根据您管理的圈子情况,未能达到要求,暂时取消您的版主,请您再接再厉,“#ForumName#”等着您哟!"; break;
                    case MessageTemplateOption.CancelTopByCircleTopic: group = "兴趣社区"; value = "很遗憾的通知您,您在“#ForumName#”的帖子“#TopicTitle#”被取消置顶,不要伤心,么么哒!"; break;
                    case MessageTemplateOption.CircleEventBefore: group = "兴趣社区"; value = "您报名的活动“#TopicTitle#”将在#EventTime#开始，千万不要错误哦！"; break;//FUCK
                    case MessageTemplateOption.CircleTopicDeleted: group = "兴趣社区"; value = "很遗憾的通知您,,您在“#ForumName#”的帖子“#TopicTitle#”被管理员删除,不要伤心,么么哒!"; break;
                    case MessageTemplateOption.SetHotByCircleTopic: group = "兴趣社区"; value = ""; break;//FUCK
                    case MessageTemplateOption.SetModerator: group = "兴趣社区"; value = ""; break;//FUCK
                    case MessageTemplateOption.SetTopByCircleTopic: group = "兴趣社区"; value = ""; break;//FUCK
                    //反馈举报
                    case MessageTemplateOption.ComplaintsSuccess: group = "反馈举报"; value = "您好，您的举报信息已经受理，管理员会跟进处理！"; break;
                    case MessageTemplateOption.FeedbackSuccess: group = "反馈举报"; value = "您好，您反馈的意见我们悉心接纳，期待我们的改变吧！"; break;
                    //登录注册
                    case MessageTemplateOption.FirstLogin: group = "登录注册"; value = "您好，欢迎加入胶东生活，胶东人自己的生活圈！"; break;//FUCK
                    //订单
                    case MessageTemplateOption.MerchantCancelGoodsOrder: group = "订单"; value = ""; break;//FUCK
                    case MessageTemplateOption.MerchantCancelServiceOrder: group = "订单"; value = ""; break;//FUCK
                    case MessageTemplateOption.MerchantSureGoodsOrder: group = "订单"; value = ""; break;//FUCK
                    case MessageTemplateOption.MerchantSureServiceOrder: group = "订单"; value = ""; break;//FUCK
                    case MessageTemplateOption.OrderCancelAndBackMoneySuccess: group = "订单"; value = ""; break;//FUCK
                    case MessageTemplateOption.OrderPaymentTimeOut: group = "订单"; value = ""; break;//FUCK
                    case MessageTemplateOption.OrderReceiving: group = "订单"; value = ""; break;//FUCK
                    case MessageTemplateOption.PaymentSuccess: group = "订单"; value = ""; break;//FUCK
                    case MessageTemplateOption.PersonalSureServiceOrder: group = "订单"; value = ""; break;//FUCK
                    case MessageTemplateOption.RechargeSuccess: group = "订单"; value = ""; break;//FUCK
                    case MessageTemplateOption.ServiceOrderBeforTime: group = "订单"; value = ""; break;//FUCK
                    case MessageTemplateOption.ServiceOrderGrabMessage: group = "订单"; value = ""; break;//FUCK
                    case MessageTemplateOption.ServiceOrderGrabSuccess: group = "订单"; value = ""; break;//FUCK
                    //认证
                    case MessageTemplateOption.UserCertificationFailure: group = "认证"; value = ""; break;//FUCK
                    case MessageTemplateOption.UserCertificationSuccess: group = "认证"; value = ""; break;//FUCK
                    //积分等级
                    case MessageTemplateOption.UserLevelUpgrade: group = "积分等级"; value = ""; break;//FUCK
                    //限时福利
                    case MessageTemplateOption.WelfareAuditSuccess: group = "限时福利"; value = ""; break;//FUCK
                    case MessageTemplateOption.WelfareBeforLoseEfficacy: group = "限时福利"; value = ""; break;//FUCK
                    case MessageTemplateOption.WelfareFinish: group = "限时福利"; value = ""; break;//FUCK
                    case MessageTemplateOption.WelfareLottery: group = "限时福利"; value = ""; break;//FUCK
                    case MessageTemplateOption.WelfareUsed: group = "限时福利"; value = ""; break;//FUCK
                    case MessageTemplateOption.WelfareWin: group = "限时福利"; value = ""; break;//FUCK
                    case MessageTemplateOption.WithdrawSuccess: group = "限时福利"; value = ""; break;//FUCK
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
                    case SmsTemplateOption.FindPassword: group = "登录注册"; value = ""; break;//FUCK
                    case SmsTemplateOption.Register: group = "登录注册"; value = ""; break;//FUCK
                    //认证审核
                    case SmsTemplateOption.MerchantAuditFailure: group = "认证审核"; value = ""; break;//FUCK
                    case SmsTemplateOption.MerchantAuditSuccess: group = "认证审核"; value = ""; break;//FUCK
                    //业务申请审核
                    case SmsTemplateOption.ServiceBusinessOpenFailure: group = "业务申请审核"; value = ""; break;//FUCK
                    case SmsTemplateOption.ServiceBusinessOpenSuccess: group = "业务申请审核"; value = ""; break;//FUCK
                    //通知
                    case SmsTemplateOption.WithdrawNotice: group = "提现通知"; value = ""; break;//FUCK
                }

                Add((int)GlobalConfigType.SMS, kv.Key, kv.Value, value.ToString(), group, unit);
            }
        }
    }
}
