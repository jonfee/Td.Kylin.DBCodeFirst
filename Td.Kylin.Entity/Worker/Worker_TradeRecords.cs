using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 服务职员交易记录
    /// </summary>
    [Table("Worker_TradeRecords",Schema ="dbo")]
    public class Worker_TradeRecords
    {
        /// <summary>
        /// 交易ID
        /// </summary>
        public long TradeID { get; set; }

        ///<summary>
        ///服务职员ID
        ///</summary>
        public long WorkerID { get; set; }

        /// <summary>
        /// 交易类型（如：服务销售｜提现等）
        /// </summary>
        public int TradeType { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 交易信息
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string TradeInfo { get; set; }

        /// <summary>
        /// 支付方式（如：余额，微信支付，支付宝）
        /// </summary>
        public int PaymentType { get; set; }

        /// <summary>
        /// 第三方交易流水号（一般用于第三方支付系统时）
        /// </summary>
        [Column(TypeName = "varchar(30)")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 数据产生时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
