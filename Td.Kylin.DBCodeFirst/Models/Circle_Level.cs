
using System;

namespace Td.Kylin.DBCodeFirst.Models
{
	/// <summary>
	/// Circle_Level
	/// </summary>
	public partial class Circle_Level
	{		
		///<summary>
		///数据ID
		///</summary>
		public long LevelID{get;set;}
				
		///<summary>
		///等级名称
		///</summary>
		public string Name{get;set;}
				
		///<summary>
		///最小积分
		///</summary>
		public int Min{get;set;}
				
		///<summary>
		///是否启用
		///</summary>
		public bool Enable{get;set;}
				
		///<summary>
		///创建时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
	}
}
