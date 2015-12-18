using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 折扣商品福利信息（从）
    /// </summary>
    [Table("Welfare_Goods", Schema = "dbo")]
    public class Welfare_Goods
    {
        /// <summary>
        /// 优惠券福利ID
        /// </summary>
        public long WelfareID { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [Column(TypeName = "nvarchar(10)")]
        public string Tag { get; set; }

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
