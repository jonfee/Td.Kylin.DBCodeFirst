using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 退款订单操作日志
    /// </summary>
    [Table("Mall_RefundOrderActiveLog")]
    public class Mall_RefundOrderActiveLog
    {
        /// <summary>
        /// 操作ID
        /// </summary>
        public long ActionLogId { get; set; }

        /// <summary>
        /// 操作的退款订单编号
        /// </summary>
        [Column(TypeName = "varchar(18)")]
        public string RefundOrderCode { get; set; }

        /// <summary>
        /// 操作者角色（枚举：MallRefundOrderOperatorRole）
        /// </summary>
        public int OperatorRole { get; set; }

        /// <summary>
        /// 操作者ID
        /// </summary>
        public long OperatorId { get; set; }

        /// <summary>
        /// 操作者名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 操作内容（描述说明）
        /// </summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Describe { get; set; }

        /// <summary>
        /// 扩展数据
        /// </summary>
        [Column(TypeName = "nvarchar(max)")]
        public string ExtraData { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
