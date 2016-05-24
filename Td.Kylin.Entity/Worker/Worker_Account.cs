using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 服务职员账户
    /// </summary>
    [Table("Worker_Account")]
    public class Worker_Account : BaseEntity
    {
        /// <summary>
        /// 服务员ID。
        /// </summary>
        public long WorkerID
        {
            get;
            set;
        }

        /// <summary>
        /// 真实姓名。
        /// </summary>
        [Column(TypeName = "nvarchar(10)")]
        public string FullName
        {
            get;
            set;
        }

        /// <summary>
        /// 工作状态。
        /// </summary>
        public short WorkingState
        {
            get;
            set;
        }

        /// <summary>
        /// 账户状态。
        /// </summary>
        public short AccountStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 激活时间。
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ActiveTime
        {
            get;
            set;
        }

        /// <summary>
        /// 激活时间。
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AuditTime
        {
            get;
            set;
        }
        /// <summary>
        /// 默认所属区域ID。
        /// </summary>
        public int DefaultAreaID
        {
            get;
            set;
        }
    }
}