using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 区域运营商对区域下商家抽成配置
    /// </summary>
    [Table("Commission_OperatorFromMerchant")]
    public class Commission_OperatorFromMerchant
    {
        /// <summary>
        /// 区域ID
        /// </summary>
        public int AreaID { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        public long MerchantID { get; set; }

        /// <summary>
        /// 抽成项（枚举：AreaMerchantCommissionOption，如：商家商品订单抽成|商家上门预约订单抽成）
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
