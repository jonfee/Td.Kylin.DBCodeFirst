﻿
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 社区圈子
    /// </summary>
    [Table("Circle_Forum", Schema = "dbo")]
    public class Circle_Forum
	{		
		///<summary>
		///版面圈子ID
		///</summary>
		public long ForumID{get;set;}
				
		///<summary>
		///论坛分类ID
		///</summary>
		public long CategoryID{get;set;}

        ///<summary>
        ///论坛名称
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string ForumName{get;set;}

        ///<summary>
        ///论坛图标
        ///</summary>
        [Column(TypeName = "varchar(50)")]
        public string Logo{get;set;}

        ///<summary>
        ///论坛介绍
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Description{get;set;}
				
		///<summary>
		///帖子数量
		///</summary>
		public int TopicCount{get;set;}
				
		///<summary>
		///回帖数据
		///</summary>
		public int ReplyCount{get;set;}
				
		///<summary>
		///今天帖子数量
		///</summary>
		public int TodayTopicCount{get;set;}
				
		///<summary>
		///今天回帖数量
		///</summary>
		public int TodayReplyCount{get;set;}
				
		///<summary>
		///关注度，关注人数
		///</summary>
		public int Attention{get;set;}
				
		///<summary>
		///通过总数据，日数据等计算出来的一个热度值
		///</summary>
		public int Hot{get;set;}

        ///<summary>
        ///版主
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Moderators{get;set;}
				
		///<summary>
		///论坛分类排序
		///</summary>
		public int OrderNo{get;set;}
				
		///<summary>
		///发帖类型2n次方
		///</summary>
		public int PostType{get;set;}
				
		///<summary>
		///发帖等级限制
		///</summary>
		public int PostLevel{get;set;}
				
		///<summary>
		///不需要审核等级限制
		///</summary>
		public int PassLevel{get;set;}

        ///<summary>
        ///逻辑删除时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime? DeleteTime{get;set;}
				
		///<summary>
		///是否禁用
		///</summary>
		public bool Disabled{get;set;}
				
		///<summary>
		///是否逻辑删除
		///</summary>
		public bool IsDelete{get;set;}

        ///<summary>
        ///数据建立时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime{get;set;}
				
	}
}