using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 全心直营运费模板
    /// </summary>
    [Table("Mall_FreightTemplate")]
    public class Mall_FreightTemplate
    {
        /// <summary>
        /// 运费模板Id
        /// </summary>
        public long FreightId { get; set; }

        /// <summary>
        /// 所属区域
        /// </summary>
        public int AreaId { get; set; }

        /// <summary>
        /// 运费模板名称
        /// </summary>
        [Column(TypeName = "nvarchar(30)")]
        public string Name { get; set; }

        /// <summary>
        /// 是否为独立包裹配送运费模板（即不与其它任何运费模板放置在同一包裹中）
        /// </summary>
        public bool IsSinglePackageFreight { get; set; }

        /// <summary>
        /// 支持的配送方式集合（枚举：DistributionType的累加值，如同城配送为1，快递为2，若两种配送都支持，则值为3）
        /// </summary>
        public int DistributionType { get; set; }

        /// <summary>
        /// 是否卖家包邮
        /// </summary>
        public bool IsFreeShip { get; set; }

        /// <summary>
        /// 计价方式（枚举：FreightValuationType），当卖家包邮时无意义
        /// </summary>
        public int FreightValuationType { get; set; }

        /// <summary>
        /// 是否已被删除
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public  DateTime UpdateTime { get; set; }
    }
}
