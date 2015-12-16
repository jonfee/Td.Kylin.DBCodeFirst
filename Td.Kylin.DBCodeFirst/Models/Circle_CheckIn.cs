
using System;

namespace Td.Kylin.DBCodeFirst.Models
{
	/// <summary>
	/// Circle_CheckIn
	/// </summary>
	public partial class Circle_CheckIn
	{		
		///<summary>
		///签到记录ID
		///</summary>
		public long CheckID{get;set;}
				
		///<summary>
		///签到用户ID
		///</summary>
		public long UserId{get;set;}
				
		///<summary>
		///签到时间
		///</summary>
		public DateTime CheckTime{get;set;}
				
	}
}
