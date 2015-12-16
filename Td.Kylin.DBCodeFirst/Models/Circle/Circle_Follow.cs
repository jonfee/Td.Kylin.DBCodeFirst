
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 圈子关注
    /// </summary>
    [Table("Circle_Follow", Schema = "dbo")]
    public class Circle_Follow
	{		
		///<summary>
		///版面圈子ID
		///</summary>
		public long ForumID{get;set;}
				
		///<summary>
		///关注用户ID
		///</summary>
		public long UserID{get;set;}
				
		///<summary>
		///最后活跃时间
		///</summary>
		public DateTime LastTime{get;set;}
				
		///<summary>
		///关注时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
	}
}
