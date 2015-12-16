
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 社区活动报名用户
    /// </summary>
    [Table("Circle_EventUser", Schema = "dbo")]
    public class Circle_EventUser
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
        [Column(TypeName = "nvarchar"), MaxLength(20)]
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
