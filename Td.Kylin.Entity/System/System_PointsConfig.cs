using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 系统积分配置
    /// </summary>
    [Table("System_PointsConfig")]
    public class System_PointsConfig
    {
        /// <summary>
        /// 业务活动类型（枚举：PointsActivityType） 
        /// </summary>
        public int ActivityType { get; set; }

        /// <summary>
        /// 影响的积分值（注：扣除积分时用“－”表示，如：-10）
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// 上限分值（注：为0时表示不限制，扣除积分限制时用“－”表示，如：-10）
        /// </summary>
        public int MaxLimit { get; set; }

        /// <summary>
        /// 上限单位（枚举：PointsMaxLimitUnit）
        /// </summary>
        public int MaxUnit { get; set; }

        /// <summary>
        /// 是否可重复
        /// </summary>
        public bool Repeatable { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}
