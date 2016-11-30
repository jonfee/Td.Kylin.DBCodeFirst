using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 配送订单记录
    /// </summary>
    [Table("Distribution_OrderRecord")]
    public class Distribution_OrderRecord
    {
        /// <summary>
        ///     记录ID，主键
        /// </summary>
        public long RecordId
        {
            get;
            set;
        }

        /// <summary>
        ///     订单ID，关联 Distribution_Order 表
        /// </summary>
        public long OrderId
        {
            get;
            set;
        }

        /// <summary>
        ///     操作环节，关联 Distribution_OrderOperationSection 枚举
        /// </summary>
        public short OperationSection
        {
            get;
            set;
        }

        /// <summary>
        ///     操作人
        /// </summary>
        public long? OperatorId
        {
            get;
            set;
        }

        /// <summary>
        ///     操作人名称
        /// </summary>
        [Column(TypeName = "nvarchar(10)")]
        public string OperatorName
        {
            get;
            set;
        }

        /// <summary>
        ///     操作摘要
        /// </summary>
        [Column(TypeName = "nvarchar(500)")]
        public string Summary
        {
            get;
            set;
        }

        /// <summary>
        ///     操作时间
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedTime
        {
            get;
            set;
        }
    }
}
