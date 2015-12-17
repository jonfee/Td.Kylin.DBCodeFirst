using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity.Welfare
{
    /// <summary>
    /// 优惠券福利信息（从）
    /// </summary>
    [Table("Welfare_Coupon",Schema ="dbo")]
    public class Welfare_Coupon
    {
        /// <summary>
        /// 优惠券福利ID
        /// </summary>
        public long WelfareID { get; set; }

        /// <summary>
        /// 面值金额
        /// </summary>
        public decimal FaceMoney { get; set; }

        /// <summary>
        /// 最少满足金额时使用（例：100，表示必须满100以上才能使用该优惠券）
        /// </summary>
        public decimal MinAccount { get; set; }

        /// <summary>
        /// 每人限领数量（为0时表示不限制）
        /// </summary>
        public int LimitNumber { get; set; }

        /// <summary>
        /// 使用方式
        /// </summary>
        public int UseType { get; set; }

        /// <summary>
        /// 是否原价商品时才能使用
        /// </summary>
        public bool MustUseForOriginalPrice { get; set; }
    }
}
