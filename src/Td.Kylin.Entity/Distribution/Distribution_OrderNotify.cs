using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 配送订单通知表
    /// </summary>
    [Table("Distribution_OrderNotify")]
    public class Distribution_OrderNotify
    {
        /// <summary>
        /// 通知ID，主键
        /// </summary>
        public long NotifyId
        {
            get;
            set;
        }

        /// <summary>
        /// 订单ID，关联 Distribution_Order 表
        /// </summary>
        public long OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// 	配送员ID，关联 User_Account 表
        /// </summary>
        public long MemberId
       {
           get;
           set;
       }

        /// <summary>
        /// 通知时间
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedTime
        {
            get;
            set;
        }
    }
}
