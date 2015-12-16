
using System;

namespace Td.Kylin.DBCodeFirst.Models
{
	/// <summary>
	/// Mall_OrderProductSnapshot
	/// </summary>
	public partial class Mall_OrderProductSnapshot
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
		public string Specs{get;set;}
				
		///<summary>
		///商品名称
		///</summary>
		public string Name{get;set;}
				
		///<summary>
		///商品编号
		///</summary>
		public string Code{get;set;}
				
		///<summary>
		///所属类目
		///</summary>
		public long CategoryID{get;set;}
				
		///<summary>
		///商品标签ID集合
		///</summary>
		public string TagIDs{get;set;}
				
		///<summary>
		///商家名称
		///</summary>
		public string VenderName{get;set;}
				
		///<summary>
		///发布者
		///</summary>
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
		public string MainPic{get;set;}
				
		///<summary>
		///商品展示图集
		///</summary>
		public string Pics{get;set;}
				
		///<summary>
		///商品详情描述
		///</summary>
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
		public string PromotionTags{get;set;}
				
		///<summary>
		///是否已评价
		///</summary>
		public bool HasEvaluate{get;set;}
				
	}
}
