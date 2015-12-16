
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 商品分类
    /// </summary>
    [Table("Mall_Category",Schema ="dbo")]
    public class Mall_Category
	{		
		///<summary>
		///商品类目ID
		///</summary>
		public long CategoryID{get;set;}
				
		///<summary>
		///类目名称
		///</summary>
		public string Name{get;set;}
				
		///<summary>
		///类目图标
		///</summary>
		public string Ico{get;set;}
				
		///<summary>
		///类目描述
		///</summary>
		public string Description{get;set;}
				
		///<summary>
		///排序值
		///</summary>
		public int OrderNo{get;set;}
				
		///<summary>
		///是否已禁用
		///</summary>
		public bool Disabled{get;set;}
				
		///<summary>
		///是否已逻辑删除
		///</summary>
		public bool IsDelete{get;set;}
				
		///<summary>
		///商品数
		///</summary>
		public int ProductNumber{get;set;}
				
		///<summary>
		///数据建立时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
		///<summary>
		///数据删除删除时间
		///</summary>
		public DateTime DeleteTime{get;set;}
				
	}
}
