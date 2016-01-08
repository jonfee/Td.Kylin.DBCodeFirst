﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家消息
    /// </summary>
    [Table("Merchant_Message", Schema = "dbo")]
    public class Merchant_Message
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        public long MessageID { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        public long MerchantID { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public int MessageType { get; set; }

        /// <summary>
        /// 消息主题
        /// </summary>
        [Column(TypeName = "nvarchar(30)")]
        public string Title { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [Column(TypeName = "nvarchar(500)")]
        public string Content { get; set; }

        /// <summary>
        /// 签名（如：某某物业集团）
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Sign { get; set; }

        /// <summary>
        /// 是否已读
        /// </summary>
        public bool IsRead { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 消息发送时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
