﻿
using System;

namespace Td.Kylin.DBCodeFirst.Models
{
	/// <summary>
	/// Mall_ShoppingCart
	/// </summary>
	public partial class Mall_ShoppingCart
	{		
		///<summary>
		///购物车ID
		///</summary>
		public long CartID{get;set;}
				
		///<summary>
		///用户ID
		///</summary>
		public long UserID{get;set;}
				
		///<summary>
		///关联商品ID
		///</summary>
		public long ProductID{get;set;}
				
		///<summary>
		///Sku编号ID
		///</summary>
		public long SkuID{get;set;}
				
		///<summary>
		///数量
		///</summary>
		public int Number{get;set;}
				
		///<summary>
		///加入购物车时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
		///<summary>
		///最后更新时间
		///</summary>
		public DateTime UpdateTime{get;set;}
				
	}
}
