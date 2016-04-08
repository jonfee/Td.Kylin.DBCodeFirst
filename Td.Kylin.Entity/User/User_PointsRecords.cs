using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 用户积分记录
    /// </summary>
    [Table("用户积分记录")]
    public class User_PointsRecords
    {
        /// <summary>
        /// 记录ID
        /// </summary>
        public long RecordsID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 业务活动类型（枚举：PointsActivityType） 
        /// </summary>
        public int ActivityType { get; set; }

        /// <summary>
        /// 影响的积分值（注：扣除积分时用“－”表示，如：-10）
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// 备注/摘要
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
