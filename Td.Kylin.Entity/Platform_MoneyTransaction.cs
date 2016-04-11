using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 平台资金交易流水
    /// </summary>
    [Table("Platform_MoneyTransaction")]
    public class Platform_MoneyTransaction
    {
        /// <summary>
        /// 交易流水号（共24位，由23位通用交易流水号+1位交易项序号组成）
        /// <para>23位通用流水号说明：1-6位表示年月日（160101，即：2016年1月1日），7-8位表示交易类型（10，交易类型枚举值），9-14位表示交易所在区域编号（110000，如：北京），15-23位表示系统随机数（避免重复）</para>
        /// <para>主交易流水号示例：160101101100001234567893，1-23位为通用流水号，24位（即末位）表示本次交易共产生3项子交易业务（含自己）的总数</para>
        /// <para>子交易流水号示例：160101101100001234567891，1-23位为通用流水号，24位（即末位）表示此交易流水记录在本次交易中的序号（1，表示第1项子业务）</para>
        /// </summary>
        [Column(TypeName ="varchar(24)")]
        public string TransactionCode { get; set; }

        /// <summary>
        /// 客户账号ID
        /// </summary>
        public long CustomAccountID { get; set; }

        /// <summary>
        /// 客户身份（枚举：CounterpartyIdentity）
        /// </summary>
        public int CustomIdentity { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string CustomName { get; set; }

        /// <summary>
        /// 交易类型（PlatformTransactionType）
        /// </summary>
        public int TransactionType { get; set; }

        /// <summary>
        /// 变动的资金（支出时使用负数，如：-10.05）
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 是否为主交易业务
        /// </summary>
        public bool IsMainTransaction { get; set; }

        /// <summary>
        /// 第三方交易流水号
        /// </summary>
        [Column(TypeName = "varchar(30)")]
        public string ThirdTransactionCode { get; set; }

        /// <summary>
        /// 交易摘要/备注
        /// </summary>
        [Column(TypeName = "varchar(150)")]
        public string Remark { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        public DateTime TransactionTime { get; set; }
    }
}
