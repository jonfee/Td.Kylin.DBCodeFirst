
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 回复记录
    /// </summary>
    [Table("Circle_PostTrend", Schema = "dbo")]
    public class Circle_PostTrend
	{		
		///<summary>
		///数据ID
		///</summary>
		public long TrendsID{get;set;}
				
		///<summary>
		///发起回复的用户ID
		///</summary>
		public long UserID{get;set;}
				
		///<summary>
		///是否为主题回复
		///</summary>
		public bool IsReplyTopic{get;set;}
				
		///<summary>
		///主题ID
		///</summary>
		public long TopicID{get;set;}
				
		///<summary>
		///帖子ID
		///</summary>
		public long PostID{get;set;}
				
		///<summary>
		///贴中贴，点赞，踩贴ID
		///</summary>
		public long RespondID{get;set;}
				
		///<summary>
		///原帖用户ID
		///</summary>
		public long PostUserID{get;set;}
				
		///<summary>
		///被回复的用户ID
		///</summary>
		public long AtUserID{get;set;}

        ///<summary>
        ///内容预览
        ///</summary>
        [Column(TypeName = "nvarchar"), MaxLength(255)]
        public string Content{get;set;}
				
		///<summary>
		///回帖，点赞，踩
		///</summary>
		public int Action{get;set;}
				
		///<summary>
		///是否无效（数据源被删掉）
		///</summary>
		public bool Disable{get;set;}
				
		///<summary>
		///是否已查看
		///</summary>
		public bool IsRead{get;set;}
				
		///<summary>
		///创建时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
	}
}
