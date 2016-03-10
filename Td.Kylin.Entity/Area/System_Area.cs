using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 区域表
    /// </summary>
    [Table("System_Area")]
    public class System_Area
    {
        /// <summary>
        /// 区域ID
        /// </summary>
        public int AreaID { get; set; }
        /// <summary>
        /// 地区名称
        /// </summary>
        [Column(TypeName = "varchar(15)")]
        public string AreaName { get; set; }
        /// <summary>
        /// 父ID（1级为0）
        /// </summary>
        public int ParentID { get; set; }
        /// <summary>
        /// 地区级别（1为省级，2为市级，3为区、县、地级市级，4为镇，5为村、街道）
        /// </summary>
        public int Depth { get; set; }
        /// <summary>
        /// 地区级别（1为省级，2为市级，3为区、县、地级市级，4为镇，5为村、街道）
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string NameSpell { get; set; }
        /// <summary>
        /// 区域路径（如：110000|110100|110101）
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Layer { get; set; }
        /// <summary>
        /// 是否下级
        /// </summary>
        public bool HasChild { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        
        public DateTime UpdateTime { get; set; }


   
    }
}
