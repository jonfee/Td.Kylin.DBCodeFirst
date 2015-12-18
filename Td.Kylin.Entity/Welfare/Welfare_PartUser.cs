using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    [Table("Welfare_PartUser",Schema ="dbo")]
    public class Welfare_PartUser
    {
        /// <summary>
        /// 福利发放ID
        /// </summary>
        public long StageID { get; set; }

        /// <summary>
        /// 参与用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 参与编号
        /// </summary>
        [Column(TypeName = "varchar(16)")]
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
        [Column(TypeName = "datetime")]
        public DateTime? AwardTime { get; set; }

        /// <summary>
        /// 数据创建时间（即参与时间）
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
