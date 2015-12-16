
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 帖子及评论位置
    /// </summary>
    [Table("Circle_Location", Schema = "dbo")]
    public class Circle_Location
	{		
		///<summary>
		///数据ID
		///</summary>
		public long LocationID{get;set;}
				
		///<summary>
		///主题ID
		///</summary>
		public long TopicID{get;set;}
				
		///<summary>
		///回帖ID
		///</summary>
		public long PostID{get;set;}
				
		///<summary>
		///纬度
		///</summary>
		public Single Latitude{get;set;}
				
		///<summary>
		///经度
		///</summary>
		public Single Longitude{get;set;}
				
	}
}
