
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 用户社区信息
    /// </summary>
    [Table("User_Forum", Schema = "dbo")]
    public class User_Forum
	{
        ///<summary>
        ///用户ID
        ///</summary>
        [Key]
        public long UserID{get;set;}
				
		///<summary>
		///用户角色（普通用户，版主，超级版主）
		///</summary>
		public int Role{get;set;}
				
		///<summary>
		///发布帖子数量
		///</summary>
		public int TopicCount{get;set;}
				
		///<summary>
		///回帖数量
		///</summary>
		public int ReplyCount{get;set;}
				
		///<summary>
		///精华帖数量
		///</summary>
		public int ClassicsCount{get;set;}
				
		///<summary>
		///删除的主帖子数
		///</summary>
		public int DeleteCount{get;set;}
				
		///<summary>
		///删除的回帖数
		///</summary>
		public int DeleteReplyCount{get;set;}
				
		///<summary>
		///不喜欢、踩
		///</summary>
		public int DislikeCount{get;set;}
				
		///<summary>
		///点赞支持
		///</summary>
		public int SupportCount{get;set;}
				
		///<summary>
		///用户在论坛的行为得分
		///</summary>
		public int Score{get;set;}
				
		///<summary>
		///未查看的数据动态数量
		///</summary>
		public int TrendsCount{get;set;}
				
		///<summary>
		///最后查看数据动态时间
		///</summary>
		public DateTime LastRead{get;set;}
				
	}
}
