
using System;

namespace Td.Kylin.DBCodeFirst.Models
{
	/// <summary>
	/// Circle_Event
	/// </summary>
	public partial class Circle_Event
	{		
		///<summary>
		///活动ID
		///</summary>
		public long EventID{get;set;}
				
		///<summary>
		///主题ID
		///</summary>
		public long TopicID{get;set;}
				
		///<summary>
		///用户ID
		///</summary>
		public long UserID{get;set;}
				
		///<summary>
		///开始时间
		///</summary>
		public DateTime StartTime{get;set;}
				
		///<summary>
		///结束时间
		///</summary>
		public DateTime EndTime{get;set;}
				
		///<summary>
		///提醒时间（单位分钟）
		///</summary>
		public int Remind{get;set;}
				
		///<summary>
		///活动地点
		///</summary>
		public string Address{get;set;}
				
		///<summary>
		///参加活动的用户数
		///</summary>
		public int UserCount{get;set;}
				
		///<summary>
		///活动状态
		///</summary>
		public int EventStatus{get;set;}
				
		///<summary>
		///帖子发布时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
	}
}
