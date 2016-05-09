﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家交易记录
    /// </summary>
    [Table("Merchant_TradeRecords")]
    public class Merchant_TradeRecords : BaseEntity
    {
        /// <summary>
        /// 交易ID
        /// </summary>
        public long TradeID { get; set; }

        ///<summary>
        ///商家ID
        ///</summary>
        public long MerchantID { get; set; }

        /// <summary>
        /// 交易类型（枚举：MerchantTransType，如：商品销售｜服务销售｜支付服务佣金等）
        /// </summary>
        public int TradeType { get; set; }

        /// <summary>
        /// 交易对象数据ID（如订单ID）
        /// </summary>
        public long DataID { get; set; }

        /// <summary>
        /// 平台交易流水号
        /// </summary>
        public string PlatformTransactionCode { get; set; }

        /// <summary>
        /// 交易对方身份（枚举：CounterpartyIdentity）
        /// </summary>
        public int CounterpartyIdentity { get; set; }

        /// <summary>
        /// 交易对方ID（如：用户ID，商家ID，运营商ID，代理商ID）
        /// </summary>
        public long CounterpartyId { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 余额（指本次交易后的余额）
        /// </summary>
        public decimal LastBalance { get; set; }

        /// <summary>
        /// 交易信息
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string TradeInfo { get; set; }

        /// <summary>
        /// 支付方式（如：余额，微信支付，支付宝）
        /// </summary>
        public int PaymentType { get; set; }

        /// <summary>
        /// 第三方交易流水号（一般用于第三方支付系统时）
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 数据产生时间
        /// </summary>        
        public DateTime CreateTime { get; set; }
    }
}
