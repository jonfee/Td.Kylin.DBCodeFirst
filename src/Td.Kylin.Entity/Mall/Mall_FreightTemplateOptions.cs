using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 运费模板配置项信息
    /// </summary>
    [Table("Mall_FreightTemplateOptions")]
    public class Mall_FreightTemplateOptions
    {
        /// <summary>
        /// 配置项Id
        /// </summary>
        public long OptionId { get; set; }

        /// <summary>
        /// 所属运费模板Id
        /// </summary>
        public long FreightId { get; set; }

        /// <summary>
        /// 当前配送方式（枚举：DistributionType）
        /// </summary>
        public int DistributionType { get; set; }

        /// <summary>
        /// 是否默认配置
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// 区域Id集合（多个用英文逗号分隔，默认配置忽略此属性）
        /// </summary>
        [Column(TypeName = "varchar(2000)")]
        public string AreaIds { get; set; }

        /// <summary>
        /// 区域ID对应的区域名称集合（多个用英文逗号分隔）
        /// </summary>
        [Column(TypeName = "nvarchar(4000)")]
        public string AreaNames { get; set; }

        /// <summary>
        /// 首价范围内的计价数量
        /// </summary>
        public float FirstNumber { get; set; }

        /// <summary>
        /// 首价
        /// </summary>
        public decimal FirstFee { get; set; }

        /// <summary>
        /// 续价单元数量
        /// </summary>
        public float IncrementUnitNumber { get; set; }

        /// <summary>
        /// 续价单元的价格
        /// </summary>
        public decimal IncrementUnitFee { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime UpdateTime { get; set; }
    }
}
