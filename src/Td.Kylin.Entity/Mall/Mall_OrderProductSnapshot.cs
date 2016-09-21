using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 订单商品快照
    /// </summary>
    [Table("Mall_OrderProductSnapshot")]
    public class Mall_OrderProductSnapshot : BaseEntity
    {
        ///<summary>
        ///快照ID
        ///</summary>
        public long SnapshotID { get; set; }

        ///<summary>
        ///所属订单ID
        ///</summary>
        public long OrderID { get; set; }

        /// <summary>
        /// 所属包裹Id
        /// </summary>
        public long PackageId { get; set; }

        ///<summary>
        ///商品ID
        ///</summary>
        public long ProductID { get; set; }

        ///<summary>
        ///Sku编号ID
        ///</summary>
        public long SkuID { get; set; }

        ///<summary>
        ///规格名称
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Specs { get; set; }

        ///<summary>
        ///商品名称
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        ///<summary>
        ///商品编号
        ///</summary>
        [Column(TypeName = "nvarchar(18)")]
        public string Code { get; set; }

        ///<summary>
        ///所属类目
        ///</summary>
        public long CategoryID { get; set; }

        ///<summary>
        ///商品标签ID集合
        ///</summary>
        [Column(TypeName = "nvarchar(500)")]
        public string TagIDs { get; set; }

        ///<summary>
        ///商家名称
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string VenderName { get; set; }

        ///<summary>
        ///发布者
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Publisher { get; set; }

        ///<summary>
        ///市场价
        ///</summary>
        public decimal MarketPrice { get; set; }

        ///<summary>
        ///销售价
        ///</summary>
        public decimal SalePrice { get; set; }

        ///<summary>
        ///主图
        ///</summary>
        [Column(TypeName = "nvarchar(100)")]
        public string MainPic { get; set; }

        ///<summary>
        ///商品展示图集
        ///</summary>
        [Column(TypeName = "nvarchar(500)")]
        public string Pics { get; set; }

        ///<summary>
        ///商品详情描述
        ///</summary>
        [Column(TypeName = "text")]
        public string Description { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        public float Weight { get; set; }

        ///<summary>
        ///实际成交价格
        ///</summary>
        public decimal TradPrice { get; set; }

        ///<summary>
        ///购买数量
        ///</summary>
        public int BuyCounts { get; set; }

        ///<summary>
        ///实际配送费用
        ///</summary>
        public decimal TotalDeliveryFee { get; set; }

        /// <summary>
        /// 运费模板Id
        /// </summary>
        public long FreightTemplateId { get; set; }

        /// <summary>
        /// 是否独立包裹配送（即不与其它任何商品放置在同一包裹中）
        /// </summary>
        public bool IsSinglePackage { get; set; }

        /// <summary>
        /// 是否同城及时达
        /// </summary>
        public bool IsTimelyDelivery { get; set; }

        ///<summary>
        ///参与的促销ID
        ///</summary>
        public long? PromotionID { get; set; }

        ///<summary>
        ///促销标记说明
        ///</summary>
        [Column(TypeName = "nvarchar(30)")]
        public string PromotionTags { get; set; }

        ///<summary>
        ///是否已评价
        ///</summary>
        public bool HasEvaluate { get; set; }

    }
}
