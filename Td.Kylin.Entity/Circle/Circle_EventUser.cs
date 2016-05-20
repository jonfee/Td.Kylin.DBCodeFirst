
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 社区活动报名用户
    /// </summary>
    [Table("Circle_EventUser")]
    public class Circle_EventUser : BaseEntity
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
        [Column(TypeName = "nvarchar(20)")]
        public string Username{get;set;}
				
		///<summary>
		///是否需要提醒
		///</summary>
		public bool NeedRemind{get;set;}

        ///<summary>
        ///报名时间
        ///</summary>
        
        [Column(TypeName = "datetime")]public DateTime CreateTime{get;set;}
				
	}
}
