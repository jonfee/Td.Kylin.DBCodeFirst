using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 平台对区域交易抽成配置
    /// </summary>
    [Table("Commission_Platform")]
    public class Commission_Platform
    {
        /// <summary>
        /// 区域ID
        /// </summary>
        public int AreaID { get; set; }

        /// <summary>
        /// 抽成项（如：B2C订单金额抽成|商家订单交易佣金抽成）
        /// </summary>
        public int CommissionItem { get; set; }

        /// <summary>
        /// 抽成方式（如：按金额百分比|按固定金额）
        /// </summary>
        public int CommissionType { get; set; }

        /// <summary>
        /// 抽成结果
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Column(TypeName = "datetime")]public DateTime UpdateTime { get; set; }
    }
}
