using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    ///优惠券表
    /// </summary>
    [Table("Coupon_Ticket")]
    public class Coupon_Ticket
    {
        /// <summary>
        /// 优惠券ID，主键
        /// </summary>
        public long TicketID { get; set; }
        /// <summary>
        /// 	区域ID
        /// </summary>
        public int AreaID { get; set; }
        /// <summary>
        /// 优惠券编号
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string TicketCode { get; set; }
        /// <summary>
        ///优惠券定义ID，引用 Coupon_Define 表
        /// </summary>
        public long DefineID { get; set; }
        /// <summary>
        /// 优惠券类型，引用 Coupon_Type 枚举
        /// </summary>
        public short Type { get; set; }
        /// <summary>
        ///获得用户ID
        /// </summary>
        public long UserID { get; set; }
        /// <summary>
        /// 获得时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime AcquiredTime { get; set; }
        /// <summary>
        /// 是否使用(1:已使用 0:未使用)
        /// </summary>
        public bool IsUsed { get; set; }
        /// <summary>
        /// 使用时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UsedTime { get; set; }
        /// <summary>
        /// 使用的订单号
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string UsedOrder { get; set; }
        /// <summary>
        /// 面值
        /// </summary>
        public int Denomination { get; set; }
        /// <summary>
        /// 有效时间(起)
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 有效时间(止)
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime EndTime { get; set; }
    }
}
