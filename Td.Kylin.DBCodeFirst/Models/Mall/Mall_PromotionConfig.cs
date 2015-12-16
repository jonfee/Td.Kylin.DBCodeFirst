using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 促销配置
    /// </summary>
    [Table("Mall_PromotionConfig", Schema = "dbo")]
    public class Mall_PromotionConfig
	{		
		///<summary>
		///促销配置项ID
		///</summary>
		public long ConfigID{get;set;}
				
		///<summary>
		///促销ID
		///</summary>
		public long PromotionID{get;set;}
				
		///<summary>
		///买/满/加的参照金额
		///</summary>
		public decimal MinMoney{get;set;}
				
		///<summary>
		///优惠的具体配置内容
		///</summary>
		public string Value{get;set;}
				
	}
}
