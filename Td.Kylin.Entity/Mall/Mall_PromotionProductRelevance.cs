using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 促销商品关联
    /// </summary>
    [Table("Mall_PromotionProductRelevance")]
    public class Mall_PromotionProductRelevance : BaseEntity
    {
        ///<summary>
        ///促销ID
        ///</summary>
        public long PromotionID { get; set; }

        ///<summary>
        ///商品ID
        ///</summary>
        public long ProductID { get; set; }

        ///<summary>
        ///参与此次促销的数量
        ///</summary>
        public int MaxNumber { get; set; }

        ///<summary>
        ///已销售量
        ///</summary>
        public int SoldNumber { get; set; }

        ///<summary>
        ///创建时间
        ///</summary>

        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 标识集合 (例如:限时购)
        /// </summary>
        public int TagStatus { get; set; }

    }
}
