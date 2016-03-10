using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家商品
    /// </summary>
    [Table("MerchGoods_Goods")]
    public class MerchGoods_Goods : BaseEntity
    {
        /// <summary>
        /// 区域ID
        /// </summary>
        public int AreaID { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        public long GoodsID { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        public long MerchantID { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [Column(TypeName = "nvarchar(30)")]
        public string Name { get; set; }

        /// <summary>
        /// 所属自定义分类
        /// </summary>
        public long CategoryID { get; set; }

        /// <summary>
        /// 原价/市场价
        /// </summary>
        public decimal OriginalPrice { get; set; }

        /// <summary>
        /// 现价/销售价
        /// </summary>
        public decimal SalePrice { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Pic { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        public int Inventory { get; set; }

        /// <summary>
        /// 销售量
        /// </summary>
        public int SaleNumber { get; set; }

        /// <summary>
        /// 总评价数
        /// </summary>
        public int EvaluateCount { get; set; }

        /// <summary>
        /// 商品状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        ///  商品规格
        /// </summary>
        public string Specification { get; set; }
    }
}
