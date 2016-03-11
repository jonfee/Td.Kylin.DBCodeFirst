using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    [Table("Welfare_PartUser")]
    public class Welfare_PartUser : BaseEntity
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
        /// 参与编号
        /// </summary>
        [Column(TypeName = "varchar(12)")]
        public string PartCode { get; set; }

        /// <summary>
        /// 是否中奖
        /// </summary>
        public bool IsWin { get; set; }

        /// <summary>
        /// 是否已领奖
        /// </summary>
        public bool IsAward { get; set; }

        /// <summary>
        /// 领奖时间
        /// </summary>
        
        public DateTime? AwardTime { get; set; }

        /// <summary>
        /// 数据创建时间（即参与时间）
        /// </summary>
        
        public DateTime CreateTime { get; set; }
    }
}
