
using System;

namespace Td.Kylin.DBCodeFirst.Models
{
	/// <summary>
	/// Mall_Promotion
	/// </summary>
	public partial class Mall_Promotion
	{		
		///<summary>
		///促销ID
		///</summary>
		public long PromotionID{get;set;}
				
		///<summary>
		///促销名称
		///</summary>
		public string Name{get;set;}
				
		///<summary>
		///宣传海报
		///</summary>
		public string Pic{get;set;}
				
		///<summary>
		///详细描述
		///</summary>
		public string Description{get;set;}
				
		///<summary>
		///开始时间
		///</summary>
		public DateTime BeginTime{get;set;}
				
		///<summary>
		///结束时间
		///</summary>
		public DateTime EndTime{get;set;}
				
		///<summary>
		///促销类型(1：直减；2：满减)
		///</summary>
		public int PromotionType{get;set;}
				
		///<summary>
		///统一包邮
		///</summary>
		public bool FreeDelivery{get;set;}
				
		///<summary>
		///是否已逻辑删除
		///</summary>
		public bool IsDelete{get;set;}
				
		///<summary>
		///创建时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
	}
}
