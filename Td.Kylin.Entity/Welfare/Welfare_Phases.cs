using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家福利分期
    /// </summary>
    [Table("Welfare_Phases", Schema = "dbo")]
    public class Welfare_Phases
    {
        /// <summary>
        /// 福利发放ID
        /// </summary>
        public long PhasesID { get; set; }

        /// <summary>
        /// 福利ID
        /// </summary>
        public long WelfareID { get; set; }

        /// <summary>
        /// 福利类型
        /// </summary>
        public int WelfareType { get; set; }

        /// <summary>
        /// 福利数量
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// 参与人数
        /// </summary>
        public int PartNumber { get; set; }

        /// <summary>
        /// 中奖人数
        /// </summary>
        public int WinNumber { get; set; }

        /// <summary>
        /// 领奖人数
        /// </summary>
        public int AcceptNumber { get; set; }

        /// <summary>
        /// 接受参与时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 停止参与时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime StopTime { get; set; }

        /// <summary>
        /// 开奖时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime LotteryTime { get; set; }

        /// <summary>
        /// 是否启用（即上架）
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// 数据创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
