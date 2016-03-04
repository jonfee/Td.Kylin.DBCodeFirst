using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商品评价统计
    /// </summary>
    [Table("Mall_EvaluateStatistics", Schema = "dbo")]
    public class Mall_EvaluateStatistics : BaseEntity
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
