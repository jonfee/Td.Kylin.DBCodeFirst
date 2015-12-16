﻿
using System;

namespace Td.Kylin.DBCodeFirst.Models
{
	/// <summary>
	/// Mall_Product
	/// </summary>
	public partial class Mall_Product
	{		
		///<summary>
		///商品ID
		///</summary>
		public long ProductID{get;set;}
				
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
		///标签ID集合
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
		///配送费
		///</summary>
		public decimal DeliveryFee{get;set;}
				
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
		///库存
		///</summary>
		public int Inventory{get;set;}
				
		///<summary>
		///销售量
		///</summary>
		public int SoldNumber{get;set;}
				
		///<summary>
		///销售状态
		///</summary>
		public int SalesStatus{get;set;}
				
		///<summary>
		///标识状态集（推荐，新品，人气，摇一摇）
		///</summary>
		public int TagStatus{get;set;}
				
		///<summary>
		///是否已逻辑删除
		///</summary>
		public bool IsDelete{get;set;}
				
		///<summary>
		///排序值
		///</summary>
		public int OrderNo{get;set;}
				
		///<summary>
		///评价分值（介于0-5之间）
		///</summary>
		public double EvaluateScore{get;set;}
				
		///<summary>
		///数据建立时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
		///<summary>
		///最后更新时间
		///</summary>
		public DateTime UpdateTime{get;set;}
				
		///<summary>
		///促销ID
		///</summary>
		public long? PromotionID{get;set;}
				
	}
}
