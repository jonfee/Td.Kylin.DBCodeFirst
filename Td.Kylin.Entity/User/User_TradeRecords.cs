using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    [Table("User_TradeRecords",Schema ="dbo")]
    public class User_TradeRecords
    {
        public long TradeID { get; set; }

        ///<summary>
        ///用户ID
        ///</summary>
        public long UserID { get; set; }

        /// <summary>
        /// 交易类型（如：购买商品，充值等）
        /// </summary>
        public int TradeType { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 交易信息
        /// </summary>
        public string TradeInfo { get; set; }

        /// <summary>
        /// 支付方式（如：余额，微信支付，支付宝）
        /// </summary>
        public int PaymentType { get; set; }

        /// <summary>
        /// 第三方交易流水号（一般用于第三方支付系统时）
        /// </summary>
        public string TradeNo { get; set; }

        /// <summary>
        /// 数据产生时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
