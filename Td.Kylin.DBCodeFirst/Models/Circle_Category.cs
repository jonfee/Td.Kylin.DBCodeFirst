﻿
using System;

namespace Td.Kylin.DBCodeFirst.Models
{
	/// <summary>
	/// Circle_Category
	/// </summary>
	public partial class Circle_Category
	{		
		///<summary>
		///论坛分类ID
		///</summary>
		public long CategoryID{get;set;}
				
		///<summary>
		///论坛分类名称
		///</summary>
		public string Name{get;set;}
				
		///<summary>
		///论坛分类排序
		///</summary>
		public int OrderNo{get;set;}
				
		///<summary>
		///是否禁用该分类
		///</summary>
		public bool Disabled{get;set;}
				
		///<summary>
		///是否逻辑删除
		///</summary>
		public bool IsDelete{get;set;}
				
		///<summary>
		///数据建立时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
		///<summary>
		///逻辑删除时间
		///</summary>
		public DateTime? DeleteTime{get;set;}
				
	}
}
