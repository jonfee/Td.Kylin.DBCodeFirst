
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 商家所属行业
    /// </summary>
    [Table("Merchant_Industry",Schema ="dbo")]
    public class Merchant_Industry
	{
        ///<summary>
        ///行业ID
        ///</summary>
        public long IndustryID{get;set;}

        ///<summary>
        ///行业名称
        ///</summary>
        [Column(TypeName ="nvarchar"),MaxLength(20)]
        public string Name{get;set;}
				
		///<summary>
		///排序
		///</summary>
		public bool OrderNo{get;set;}
				
		///<summary>
		///是否禁用
		///</summary>
		public bool Disabled{get;set;}
				
		///<summary>
		///创建时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
	}
}
