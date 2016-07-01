using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 摘要内容
    /// </summary>
    public enum FundAbstractType
    {
        /// <summary>
        /// 用户在用户端充值成功
        /// </summary>
        [Description("用户在用户端充值成功")]
        用户在用户端充值成功 = 1,
        /// <summary>
        /// 用户在员工端充值成功
        /// </summary>
        [Description("用户在员工端充值成功")]
        用户在员工端充值成功 = 2,
        /// <summary>
        /// 用户在用户端提现成功
        /// </summary>
        [Description("用户在用户端提现成功")]
        用户在用户端提现成功 = 4,
        /// <summary>
        /// 商户在企业端提现成功
        /// </summary>
        [Description("商户在企业端提现成功")]
        商户在企业端提现成功 = 8,
        /// <summary>
        /// 用户在工作端提现成功
        /// </summary>
        [Description("用户在工作端提现成功")]
        用户在工作端提现成功 = 16,
        /// <summary>
        /// 用户购买区域运营商商品交易成功
        /// </summary>
        [Description("用户购买区域运营商商品交易成功")]
        用户购买区域运营商商品交易成功 = 32,
        /// <summary>
        /// 用户购买商家商品交易成功
        /// </summary>
        [Description("用户购买商家商品交易成功")]
        用户购买商家商品交易成功 = 64,
        /// <summary>
        /// 区域运营商对商户抽成
        /// </summary>
        [Description("区域运营商对商户抽成")]
        区域运营商对商户抽成 = 128,
        /// <summary>
        /// 区域运营商对本地服务人员抽成
        /// </summary>
        [Description("区域运营商对本地服务人员抽成")]
        区域运营商对本地服务人员抽成 = 256,
        /// <summary>
        /// 商户对员工抽成
        /// </summary>
        [Description("商户对员工抽成")]
        商户对员工抽成 = 512,
        /// <summary>
        /// 商户/员工完成服务交易成功
        /// </summary>
        [Description("商户/员工完成服务交易成功")]
        商户_员工完成服务交易成功 = 1024,
        /// <summary>
        /// 区域商品平台抽成
        /// </summary>
        [Description("平台管理后台对区域运营商自营商城订单抽成")]
        平台管理后台对区域运营商自营商城订单抽成 = 2048,
        /// <summary>
        /// 平台管理后台抽取区域运营商对商家订单抽成获得利润
        /// </summary>
        [Description("平台管理后台抽取区域运营商对商家订单抽成获得利润")]
        平台管理后台抽取区域运营商对商家订单抽成获得利润 = 4096,
        /// <summary>
        /// 区域运营商对代理商返佣
        /// </summary>
        [Description("区域运营商对代理商返佣")]
        区域运营商对代理商返佣 = 8192,
        /// <summary>
        /// 本地服务人员完成服务交易成功
        /// </summary>
        [Description("本地服务人员完成服务交易成功")]
        本地服务人员完成服务交易成功 = 16384,
        /// <summary>
        /// 平台收取提现手续费
        /// </summary>
        [Description("平台收取提现手续费")]
        平台收取提现手续费 = 32768,
        /// <summary>
        /// 用户对商户进行转账操作
        /// </summary>
        [Description("用户对商户进行转账操作")]
        用户对商户进行转账操作 = 65536,
    }
}
