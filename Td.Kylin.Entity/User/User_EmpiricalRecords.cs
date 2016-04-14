using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 用户经验记录表
    /// </summary>
    [Table("User_EmpiricalRecords")]
    public class User_EmpiricalRecords
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
        /// 影响的经验值
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
