
using System;

namespace Td.Kylin.DBCodeFirst.Models
{
	/// <summary>
	/// Circle_Post
	/// </summary>
	public partial class Circle_Post
	{		
		///<summary>
		///数据ID
		///</summary>
		public long PostID{get;set;}
				
		///<summary>
		///主题ID
		///</summary>
		public long TopicID{get;set;}
				
		///<summary>
		///用户ID
		///</summary>
		public long UserID{get;set;}
				
		///<summary>
		///用户昵称
		///</summary>
		public string Username{get;set;}
				
		///<summary>
		///帖子标题，回帖无标题
		///</summary>
		public string Title{get;set;}
				
		///<summary>
		///内容
		///</summary>
		public string Content{get;set;}
				
		///<summary>
		///帖子图片
		///</summary>
		public string Pics{get;set;}
				
		///<summary>
		///评论数
		///</summary>
		public int Reviews{get;set;}
				
		///<summary>
		///点赞支持
		///</summary>
		public int Support{get;set;}
				
		///<summary>
		///不喜欢、踩
		///</summary>
		public int Dislike{get;set;}
				
		///<summary>
		///数据建立时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
	}
}
