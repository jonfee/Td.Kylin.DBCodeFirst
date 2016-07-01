using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 经验值累积配置
    /// </summary>
    [Table("System_EmpiricalConfig")]
    public class System_EmpiricalConfig
    {
        /// <summary>
        /// 业务活动类型（枚举：UserActivityType） 
        /// </summary>
        public int ActivityType { get; set; }

        /// <summary>
        /// 影响的经验值（注：扣除经验值时用“－”表示，如：-10）
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// 上限分值（注：为0时表示不限制，扣除经验值限制时用“－”表示，如：-10）
        /// </summary>
        public int MaxLimit { get; set; }

        /// <summary>
        /// 上限单位（枚举：ScoreMaxLimitUnit）
        /// </summary>
        public int MaxUnit { get; set; }

        /// <summary>
        /// 是否可重复
        /// </summary>
        public bool Repeatable { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [Column(TypeName = "datetime")]public DateTime UpdateTime { get; set; }
    }
}
