using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 用户消息
    /// </summary>
    [Table("User_Message")]
    public class User_Message : BaseEntity
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        public long MessageID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 消息类型（枚举：MessageTemplateOption）
        /// </summary>
        public int MessageType { get; set; }

        /// <summary>
        /// 关联的数据ID
        /// </summary>
        [Column(TypeName = "nvarchar(36)")]
        public string RefDataID { get; set; }

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
        [Column(TypeName = "datetime")]public DateTime CreateTime { get; set; }
    }
}
