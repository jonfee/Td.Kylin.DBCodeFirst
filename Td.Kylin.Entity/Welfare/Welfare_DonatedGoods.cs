using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 赠送的商品福利信息（从）
    /// </summary>
    [Table("Welfare_DonatedGoods")]
    public class Welfare_DonatedGoods : BaseEntity
    {
        /// <summary>
        /// 优惠券福利ID
        /// </summary>
        public long WelfareID { get; set; }

        /// <summary>
        /// 价值
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 领取方式
        /// </summary>
        public int DrawType { get; set; }
    }
}
