
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 评论回复（帖中帖）
    /// </summary>
    [Table("Circle_Respond")]
    public class Circle_Respond : BaseEntity
    {		
		///<summary>
		///数据ID
		///</summary>
		public long RespondID{get;set;}
				
		///<summary>
		///主题ID
		///</summary>
		public long TopicID{get;set;}
				
		///<summary>
		///帖子ID
		///</summary>
		public long PostID{get;set;}
				
		///<summary>
		///回应方式（点赞、不赞、评论）
		///</summary>
		public int Type{get;set;}
				
		///<summary>
		///发布的用户ID
		///</summary>
		public long UserID{get;set;}

        ///<summary>
        ///用户名
        ///</summary>
        [Column(TypeName = "varchar(20)")]
        public string Username{get;set;}

        ///<summary>
        ///内容
        ///</summary>
        [Column(TypeName = "varchar(255)")]
        public string Content{get;set;}
				
		///<summary>
		///回应的用户ID
		///</summary>
		public long ReplyUserID{get;set;}

        ///<summary>
        ///回应的用户名
        ///</summary>
        [Column(TypeName = "varchar(20)")]
        public string ReplyUsername{get;set;}

        ///<summary>
        ///数据建立时间
        ///</summary>
        
        public DateTime CreateTime{get;set;}
				
	}
}
