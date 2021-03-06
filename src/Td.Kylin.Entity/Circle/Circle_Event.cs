﻿
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 社区活动帖信息
    /// </summary>
    [Table("Circle_Event")]
    public class Circle_Event : BaseEntity
    {		
		///<summary>
		///活动ID
		///</summary>
		public long EventID{get;set;}
				
		///<summary>
		///主题ID
		///</summary>
		public long TopicID{get;set;}
				
		///<summary>
		///用户ID
		///</summary>
		public long UserID{get;set;}

        ///<summary>
        ///开始时间
        ///</summary>
        
        [Column(TypeName = "datetime")]public DateTime StartTime{get;set;}

        ///<summary>
        ///结束时间
        ///</summary>
        
        [Column(TypeName = "datetime")]public DateTime EndTime{get;set;}
				
		///<summary>
		///提醒时间（单位分钟）
		///</summary>
		public int Remind{get;set;}

        ///<summary>
        ///活动地点
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Address{get;set;}
				
		///<summary>
		///参加活动的用户数
		///</summary>
		public int UserCount{get;set;}
				
		///<summary>
		///活动状态
		///</summary>
		public int EventStatus{get;set;}

        ///<summary>
        ///帖子发布时间
        ///</summary>
        
        [Column(TypeName = "datetime")]public DateTime CreateTime{get;set;}
				
	}
}
