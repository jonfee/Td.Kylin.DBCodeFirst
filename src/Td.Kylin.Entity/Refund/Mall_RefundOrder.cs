using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 直营退款订单
    /// </summary>
    [Table("Mall_RefundOrder")]
    public class Mall_RefundOrder
    {
        ///<summary>
        /// 退款订单编号
        ///</summary>
        [Column(TypeName = "varchar(18)")]
        public string RefundOrderCode { get; set; }

        /// <summary>
        /// 关联的直营订单编号
        /// </summary>
        [Column(TypeName = "nvarchar(18)")]
        public string WithMallOrderCode { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 是否需要退货
        /// </summary>
        public bool NeedReturnGoods { get; set; }

        /// <summary>
        /// 退款订单状态（枚举：MallRefundOrderStatus）
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 退款说明
        /// </summary>
        [Column(TypeName = "nvarchar(300)")]
        public string RefundRemark { get; set; }

        /// <summary>
        /// 审查说明（受理成功或失败时的说明）
        /// </summary>
        [Column(TypeName = "nvarchar(300)")]
        public string CheckRemark { get; set; }

        /// <summary>
        /// 退款申请时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 退款审查时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CheckedTime { get; set; }

        /// <summary>
        /// 退款业务结束时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? FinishTime { get; set; }

        /// <summary>
        /// 扩展数据
        /// </summary>
        [Column(TypeName = "nvarchar(max)")]
        public string ExtraData { get; set; }
    }
}
