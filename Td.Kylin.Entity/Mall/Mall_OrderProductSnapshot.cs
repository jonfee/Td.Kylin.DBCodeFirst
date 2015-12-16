using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 订单商品快照
    /// </summary>
    [Table("Mall_OrderProductSnapshot", Schema = "dbo")]
    public class Mall_OrderProductSnapshot
	{		
		///<summary>
		///快照ID
		///</summary>
		public long SnapshotID{get;set;}
				
		///<summary>
		///订单ID
		///</summary>
		public long OrderID{get;set;}
				
		///<summary>
		///商品ID
		///</summary>
		public long ProductID{get;set;}
				
		///<summary>
		///Sku编号ID
		///</summary>
		public long SkuID{get;set;}

        ///<summary>
        ///规格名称
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Specs{get;set;}

        ///<summary>
        ///商品名称
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Name{get;set;}

        ///<summary>
        ///商品编号
        ///</summary>
        [Column(TypeName = "varchar(18)")]
        public string Code{get;set;}
				
		///<summary>
		///所属类目
		///</summary>
		public long CategoryID{get;set;}

        ///<summary>
        ///商品标签ID集合
        ///</summary>
        [Column(TypeName = "varchar(500)")]
        public string TagIDs{get;set;}

        ///<summary>
        ///商家名称
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string VenderName{get;set;}

        ///<summary>
        ///发布者
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Publisher{get;set;}
				
		///<summary>
		///市场价
		///</summary>
		public decimal MarketPrice{get;set;}
				
		///<summary>
		///销售价
		///</summary>
		public decimal SalePrice{get;set;}

        ///<summary>
        ///主图
        ///</summary>
        [Column(TypeName = "varchar(100)")]
        public string MainPic{get;set;}

        ///<summary>
        ///商品展示图集
        ///</summary>
        [Column(TypeName = "varchar(500)")]
        public string Pics{get;set;}

        ///<summary>
        ///商品详情描述
        ///</summary>
        [Column(TypeName = "nvarchar(max)")]
        public string Description{get;set;}
				
		///<summary>
		///实际成交价格
		///</summary>
		public decimal TradPrice{get;set;}
				
		///<summary>
		///购买数量
		///</summary>
		public int BuyCounts{get;set;}
				
		///<summary>
		///实际配送费用
		///</summary>
		public decimal TotalDeliveryFee{get;set;}
				
		///<summary>
		///参与的促销ID
		///</summary>
		public long? PromotionID{get;set;}

        ///<summary>
        ///促销标记说明
        ///</summary>
        [Column(TypeName = "nvarchar(30)")]
        public string PromotionTags{get;set;}
				
		///<summary>
		///是否已评价
		///</summary>
		public bool HasEvaluate{get;set;}
				
	}
}
