using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 用户优惠券规则快照
    /// </summary>
    [Table("Coupon_Ticket_Rules")]
    public class Coupon_Ticket_Rules
    {
        /// <summary>
        /// 主键：用户优惠券ID
        /// </summary>
        public long TicketID { get; set; }
        /// <summary>
        /// 主键：派券规则，引用 Coupon_Rules 枚举
        /// </summary>
        public int Rule { get; set; }
        /// <summary>
        /// 规则值
        /// </summary>
        [Column(TypeName = "varchar(500)")]
        public string Values { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }
    }
}
