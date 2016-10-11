using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 用户充值订单
    /// </summary>
    public class User_RechargeOrder
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public long OrderID { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        [Column(TypeName ="varchar(24)")]
        public string OrderCode { get; set; }
        /// <summary>
        /// 充值金额
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        [Column(TypeName ="varchar(24)")]
        public string UserName { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserID { get; set; }
        /// <summary>
        /// 充值状态(枚举：UserRechargeStatus)
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName ="datetime")]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 充值完成时间
        /// </summary>
        [Column(TypeName ="datetime")]
        public DateTime? CompleteTime { get; set; }
        /// <summary>
        /// 拓展数据
        /// </summary>
        [Column(TypeName ="nvarchar(100)")]
        public string ExpandData { get; set; }
    }
}
