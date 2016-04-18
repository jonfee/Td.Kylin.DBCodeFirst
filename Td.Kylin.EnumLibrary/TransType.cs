
using Td.ComponentModel;


namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 交易类型
    /// </summary>
    public enum TransType
    {
        /// <summary>
        /// 用户端充值
        /// </summary>
        [Description("用户端充值")]
        用户端充值 = 1,
        /// <summary>
        /// 工作端充值
        /// </summary>
        [Description("工作端充值")]
        工作端充值 = 2,
        /// <summary>
        /// 用户端提现
        /// </summary>
        [Description("用户端提现")]
        用户端提现 = 4,
        /// <summary>
        /// 企业端提现
        /// </summary>
        [Description("企业端提现")]
        企业端提现 = 8,
        /// <summary>
        /// 工作端提现
        /// </summary>
        [Description("工作端提现")]
        工作端提现 = 16,
        /// <summary>
        /// 区域商品交易
        /// </summary>
        [Description("区域商品交易")]
        区域商品交易 = 32,
        /// <summary>
        /// 商家商品交易
        /// </summary>
        [Description("商家商品交易")]
        商家商品交易 = 64,
        /// <summary>
        /// 商户抽成
        /// </summary>
        [Description("商户抽成")]
        商户抽成 = 128,
        /// <summary>
        /// 本地服务人员抽成
        /// </summary>
        [Description("本地服务人员抽成")]
        本地服务人员抽成 = 256,
        /// <summary>
        /// 员工抽成
        /// </summary>
        [Description("员工抽成")]
        员工抽成 = 512,
        /// <summary>
        /// 商家服务交易
        /// </summary>
        [Description("商家服务交易")]
        商家服务交易 = 1024,
        /// <summary>
        /// 区域商品平台抽成
        /// </summary>
        [Description("区域商品平台抽成")]
        区域商品平台抽成 = 2048,
        /// <summary>
        /// 区域商家平台抽成
        /// </summary>
        [Description("区域商家平台抽成")]
        区域商家平台抽成 = 4096,
        /// <summary>
        /// 代理商返佣
        /// </summary>
        [Description("代理商返佣")]
        代理商返佣 = 8192,
        /// <summary>
        /// 服务人员服务交易
        /// </summary>
        [Description("服务人员服务交易")]
        服务人员服务交易 = 16384,
        /// <summary>
        /// 提现手续费
        /// </summary>
        [Description("提现手续费")]
        提现手续费 = 32768,
        /// <summary>
        /// 转账
        /// </summary>
        [Description("转账")]
        转账 = 65536,
    }
}
