using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 福利开放参与前的提醒名单
    /// </summary>
    [Table("Welfare_Remind", Schema = "dbo")]
    public class Welfare_Remind
    {
        /// <summary>
        /// 福利发放分期ID
        /// </summary>
        public long PhasesID { get; set; }

        /// <summary>
        /// 参与用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 数据创建时间（即参与时间）
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
