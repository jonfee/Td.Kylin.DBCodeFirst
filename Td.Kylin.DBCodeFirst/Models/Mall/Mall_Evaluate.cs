using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 订单商品评价
    /// </summary>
    [Table("Mall_Evaluate", Schema = "dbo")]
    public class Mall_Evaluate
	{		
		///<summary>
		///评价ID
		///</summary>
		public long EvaluateID{get;set;}
				
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
		///用户ID
		///</summary>
		public long UserID{get;set;}
				
		///<summary>
		///评价等级
		///</summary>
		public int EvaluateLevel{get;set;}
				
		///<summary>
		///评价内容
		///</summary>
		public string Contents{get;set;}
				
		///<summary>
		///评价时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
		///<summary>
		///回复内容
		///</summary>
		public string ReplyContents{get;set;}
				
		///<summary>
		///回复时间
		///</summary>
		public DateTime? ReplyTime{get;set;}
				
		///<summary>
		///是否已删除
		///</summary>
		public bool IsDelete{get;set;}
				
	}
}
