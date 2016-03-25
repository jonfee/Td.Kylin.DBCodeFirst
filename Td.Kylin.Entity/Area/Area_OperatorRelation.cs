using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 区域运营关系表
    /// </summary>
    [Table("Area_OperatorRelation")]
    public class Area_OperatorRelation : BaseEntity
    {
        /// <summary>
        /// 运营商ID
        /// </summary>
        public long OperatorID { get; set; }
        /// <summary>
        /// 区域ID
        /// </summary>
        public int  AreaID { get; set; }

        /// <summary>
        /// 运营开始时间
        /// </summary>
        
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 运营结束时间
        /// </summary>
        
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 合同号
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string CompactNumber { get; set; }
        
        /// <summary>
        /// 备注说明
        /// </summary>
        [Column(TypeName = "varchar(300)")]
        public string Remark { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        
        public DateTime CreateTime { get; set; }
    }
}
