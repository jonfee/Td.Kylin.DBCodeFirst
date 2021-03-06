﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 折扣商品福利信息（从）
    /// </summary>
    [Table("Welfare_Goods")]
    public class Welfare_Goods : BaseEntity
    {
        /// <summary>
        /// 优惠券福利ID
        /// </summary>
        public long WelfareID { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        public decimal OriginalPrice { get; set; }

        /// <summary>
        /// 折扣价
        /// </summary>
        public decimal DiscountPrice { get; set; }

        /// <summary>
        /// 领取方式
        /// </summary>
        public int DrawType { get; set; }
    }
}
