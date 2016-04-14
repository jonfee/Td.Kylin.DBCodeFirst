using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 福利开放参与前的提醒名单
    /// </summary>
    [Table("Welfare_Remind")]
    public class Welfare_Remind : BaseEntity
    {
        /// <summary>
        /// 福利ID
        /// </summary>
        public long WelfareID { get; set; }

        /// <summary>
        /// 参与用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 数据创建时间（即参与时间）
        /// </summary>
        
        public DateTime CreateTime { get; set; }
    }
}
