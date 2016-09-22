using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 运费模板免邮条件
    /// </summary>
    [Table("Mall_FreightTemplateFreeCondition")]
    public class Mall_FreightTemplateFreeCondition
    {
        /// <summary>
        /// 免费条件ID
        /// </summary>
        public long ConditionId { get; set; }

        /// <summary>
        /// 所属运费模板Id
        /// </summary>
        public long FreightId { get; set; }

        /// <summary>
        /// 免邮条件的配送方式（枚举：DistributionType）
        /// </summary>
        public int DistributionType { get; set; }

        /// <summary>
        /// 免邮条件的区域Id集合（多个用英文逗号分隔，为空表示其它地区）
        /// </summary>
        public string AreaIds { get; set; }

        /// <summary>
        /// 最低购买量（件数或重量）
        /// </summary>
        public float BuyMinimum { get; set; }

        /// <summary>
        /// 最低购买的金额（实际商品应付金额且不含运费）
        /// </summary>
        public decimal BuyMinMoney { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime UpdateTime { get; set; }
    }
}
