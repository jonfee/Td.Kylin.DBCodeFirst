using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 短信发送记录
    /// </summary>
    [Table("SmsSendRecords")]
    public class SmsSendRecords
    {
        /// <summary>
        /// 发送记录ID
        /// </summary>
        public long SendID { get; set; }

        /// <summary>
        /// 发送者ID
        /// </summary>
        public long SenderId { get; set; }

        /// <summary>
        /// 发送者类型（枚举：IdentityType）
        /// </summary>
        public int SenderType { get; set; }

        /// <summary>
        /// 接收的手机号
        /// </summary>
        [Column(TypeName = "varchar(11)")]
        public string Mobile { get; set; }

        /// <summary>
        /// 短信内容
        /// </summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Message { get; set; }

        /// <summary>
        /// 是否发送成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 发送情况说明
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string Remark { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime SendTime { get; set; }
    }
}
