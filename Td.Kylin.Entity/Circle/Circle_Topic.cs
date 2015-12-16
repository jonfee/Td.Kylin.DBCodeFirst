
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 帖子主题
    /// </summary>
    [Table("Circle_Topic", Schema = "dbo")]
    public class Circle_Topic
	{		
		///<summary>
		///主题帖数据ID
		///</summary>
		public long TopicID{get;set;}
				
		///<summary>
		///首层评论ID
		///</summary>
		public long FirstPostID{get;set;}
				
		///<summary>
		///归属版面ID
		///</summary>
		public long ForumID{get;set;}
				
		///<summary>
		///发帖的用户ID
		///</summary>
		public long UserID{get;set;}

        ///<summary>
        ///发帖的用户昵称
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Username{get;set;}
				
		///<summary>
		///帖子类型（普通、活动、商品、投票）
		///</summary>
		public int TopicType{get;set;}

        ///<summary>
        ///帖子标题
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Title{get;set;}

        ///<summary>
        ///帖子内容
        ///</summary>
        [Column(TypeName = "nvarchar(max)")]
        public string Content{get;set;}

        ///<summary>
        ///帖子图片
        ///</summary>
        [Column(TypeName = "varchar(500)")]
        public string Pics{get;set;}
				
		///<summary>
		///帖子点击次数
		///</summary>
		public int ClickCount{get;set;}
				
		///<summary>
		///商品帖子价格
		///</summary>
		public decimal Price{get;set;}
				
		///<summary>
		///回帖数
		///</summary>
		public int PostCount{get;set;}
				
		///<summary>
		///点赞数
		///</summary>
		public int LikeCount{get;set;}
				
		///<summary>
		///踩帖数
		///</summary>
		public int DislikeCount{get;set;}
				
		///<summary>
		///帖子参加活动或投票数
		///</summary>
		public int EventCount{get;set;}
				
		///<summary>
		///[活动，投票，商品ID]
		///</summary>
		public long? ItemId{get;set;}
				
		///<summary>
		///损耗、新旧程度
		///</summary>
		public int Loss{get;set;}
				
		///<summary>
		///标识状态集（以2的N次方存储，如：推荐，置顶，精华帖，摇一摇等）
		///</summary>
		public int TagStatus{get;set;}
				
		///<summary>
		///是否逻辑删除
		///</summary>
		public bool IsDelete{get;set;}

        ///<summary>
        ///逻辑删除时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime? DeleteTime{get;set;}
				
		///<summary>
		///审核状态（1审核中，2审核成功）
		///</summary>
		public int AuditStatus{get;set;}

        ///<summary>
        ///帖子发布时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime{get;set;}
				
	}
}
