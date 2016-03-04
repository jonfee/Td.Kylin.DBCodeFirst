
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 签到记录
    /// </summary>
    [Table("Circle_CheckIn", Schema = "dbo")]
    public class Circle_CheckIn : BaseEntity
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
        [Column(TypeName = "datetime")]
        public DateTime CheckTime{get;set;}
				
	}
}
