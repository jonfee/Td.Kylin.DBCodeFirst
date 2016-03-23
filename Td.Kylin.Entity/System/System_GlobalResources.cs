using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 系统全局配置
    /// </summary>
    [Table("System_GlobalResources")]
    public class System_GlobalResources
    {
        /// <summary>
        /// 资源类型
        /// </summary>
        public int ResourceType { get; set; }

        /// <summary>
        /// 资源类型键
        /// </summary>
        public int ResourceKey { get; set; }

        /// <summary>
        /// 键分组（如：B2C）
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string Group { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [Column(TypeName ="varchar(50)")]
        public string Name { get; set; }

        /// <summary>
        /// 资源值
        /// </summary>
        [Column(TypeName = "varchar(500)")]
        public string Value { get; set; }

        /// <summary>
        /// 值单位（例如：1表示小时）
        /// </summary>
        public int ValueUnit { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}
