
using System;

namespace Td.Kylin.DBCodeFirst.Models
{
	/// <summary>
	/// Mall_CategoryTag
	/// </summary>
	public partial class Mall_CategoryTag
	{		
		///<summary>
		///标签ID
		///</summary>
		public long TagID{get;set;}
				
		///<summary>
		///商品类目ID
		///</summary>
		public long CategoryID{get;set;}
				
		///<summary>
		///商品标签名称
		///</summary>
		public string TagName{get;set;}
				
		///<summary>
		///商品数
		///</summary>
		public int ProductNumber{get;set;}
				
		///<summary>
		///搜索次数
		///</summary>
		public int SearchTimes{get;set;}
				
		///<summary>
		///排序值
		///</summary>
		public int OrderNo{get;set;}
				
		///<summary>
		///标签创建时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
	}
}
