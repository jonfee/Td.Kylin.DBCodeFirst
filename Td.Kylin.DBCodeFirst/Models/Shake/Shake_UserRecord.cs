using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 摇一摇记录
    /// </summary>
    [Table("Shake_UserRecord", Schema = "dbo")]
    public partial class Shake_UserRecord
	{
        ///<summary>
        ///记录ID
        ///</summary>
        public long RecordID{get;set;}
				
		///<summary>
		///用户ID
		///</summary>
		public long UserID{get;set;}
				
		///<summary>
		///主题ID
		///</summary>
		public long ContentID{get;set;}
				
		///<summary>
		///标题
		///</summary>
		public string Title{get;set;}
				
		///<summary>
		///原价
		///</summary>
		public decimal CostPrice{get;set;}
				
		///<summary>
		///价格
		///</summary>
		public decimal Price{get;set;}
				
		///<summary>
		///最后支付时间
		///</summary>
		public DateTime? LastPayTime{get;set;}
				
		///<summary>
		///建立时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
	}
}
