using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 配送员操作记录
    /// </summary>
    [Table("Distribution_MemberOperationRecord")]
    public class Distribution_MemberOperationRecord
    {
        /// <summary>
        /// 主键
        /// </summary>
        public long RecordId
        {
            get;
            set;
        }

        /// <summary>
        /// 关联 Distribution_Member 表
        /// </summary>
        public long MemberId
        {
            get;
            set;
        }

        /// <summary>
        ///  配送员操作类型 枚举:(Distribution_MemberOperationType)
        /// </summary>
        public short OperationType
        {
            get;
            set;
        }

        /// <summary>
        /// 	操作摘要
        /// </summary>
        [Column(TypeName = "nvarchar(500)")]
        public string Summmary
        {
            get;
            set;
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedTime
        {
            get;
            set;
        }
    }
}
