
using System;

namespace Td.Kylin.DBCodeFirst.Models
{
	/// <summary>
	/// Circle_EventUser
	/// </summary>
	public partial class Circle_EventUser
	{		
		///<summary>
		///数据ID
		///</summary>
		public long EventUserId{get;set;}
				
		///<summary>
		///活动ID
		///</summary>
		public long EventID{get;set;}
				
		///<summary>
		///用户ID
		///</summary>
		public long UserID{get;set;}
				
		///<summary>
		///用户昵称
		///</summary>
		public string Username{get;set;}
				
		///<summary>
		///是否需要提醒
		///</summary>
		public bool NeedRemind{get;set;}
				
		///<summary>
		///报名时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
	}
}
