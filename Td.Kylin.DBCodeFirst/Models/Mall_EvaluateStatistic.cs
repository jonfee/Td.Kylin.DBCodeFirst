
using System;

namespace Td.Kylin.DBCodeFirst.Models
{
	/// <summary>
	/// Mall_EvaluateStatistic
	/// </summary>
	public partial class Mall_EvaluateStatistic
	{		
		///<summary>
		///商品ID
		///</summary>
		public long ProductID{get;set;}
				
		///<summary>
		///评价等级
		///</summary>
		public int EvaluateLevel{get;set;}
				
		///<summary>
		///总评价次数
		///</summary>
		public int Counts{get;set;}
				
	}
}
