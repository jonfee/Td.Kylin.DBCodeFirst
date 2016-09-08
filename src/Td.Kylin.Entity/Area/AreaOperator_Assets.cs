using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 运营商资产
    /// </summary>
    [Table("AreaOperator_Assets")]
    public class AreaOperator_Assets
    {
        /// <summary>
        /// 区域运营商ID
        /// </summary>
        public long OperatorID { get; set; }

        /// <summary>
        /// 资产类型（枚举：OperatorAssetsType）
        /// </summary>
        public int AssetsType { get; set; }

        /// <summary>
        /// 剩余数量
        /// </summary>
        public int Balance { get; set; }

        /// <summary>
        /// 已使用数量
        /// </summary>
        public  int UsedNumber { get; set; }

        /// <summary>
        /// 可使用开始时间（为null时不限制）
        /// </summary>
        [Column(TypeName = "datetime")]
        public  DateTime? BeginTime { get; set; }

        /// <summary>
        /// 可使用结束时间（为null时不限制）
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column(TypeName = "nvarchar(500)")]
        public  string Remark { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public  DateTime UpdateTime { get; set; }
    }
}
