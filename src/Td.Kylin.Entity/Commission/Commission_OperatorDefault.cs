using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 运营商（区域）默认抽成配置
    /// </summary>
    [Table("Commission_OperatorDefault")]
    public class Commission_OperatorDefault
    {
        /// <summary>
        /// 区域ID
        /// </summary>
        public int AreaID { get; set; }

        /// <summary>
        /// 抽成项（枚举：AreaDefaultCommissionOption，如：商家商品订单抽成|商家上门预约订单抽成）
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
