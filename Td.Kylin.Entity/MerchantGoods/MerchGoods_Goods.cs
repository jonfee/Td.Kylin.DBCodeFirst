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
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }

        /// <summary>
        /// 所属商家的区域ID（一般为区县ID）
        /// </summary>
        public int AreaID { get; set; }

        /// <summary>
        /// 区域路径（如：110000|110100|110101）
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string AreaLayer { get; set; }

        /// <summary>
        /// 所属系统商品分类（MerchantGoods_SystemCategory.CategoryID）
        /// </summary>
        public long SystemCategoryID { get; set; }

        /// <summary>
        /// 所属自定义分类（未选择时为0）
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
        [Column(TypeName = "varchar(200)")]
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

        ///<summary>
        ///标识状态集（推荐，新品，人气）
        ///</summary>
        public int TagStatus { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>

        public DateTime CreateTime { get; set; }

        /// <summary>
        ///  商品规格
        /// </summary>
        [Column(TypeName = "varchar(30)")]
        public string Specification { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [Column(TypeName = "varchar(140)")]

        public string Description { get; set; }
        ///<summary>
        ///纬度
        ///</summary>
        public Single Latitude { get; set; }

        ///<summary>
        ///经度
        ///</summary>
        public Single Longitude { get; set; }
        /// <summary>
        /// 点击率
        /// </summary>
        public int Click { get; set; }
    }
}
