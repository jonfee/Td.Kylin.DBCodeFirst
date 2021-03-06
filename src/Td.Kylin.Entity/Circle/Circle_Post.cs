﻿
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 社区评论
    /// </summary>
    [Table("Circle_Post")]
    public class Circle_Post : BaseEntity
    {
        ///<summary>
        ///数据ID
        ///</summary>
        public long PostID { get; set; }

        ///<summary>
        ///主题ID
        ///</summary>
        public long TopicID { get; set; }
        /// <summary>
        /// 评论父ID
        /// </summary>
        public long ParentPostID { get; set; }
        ///<summary>
        ///用户ID
        ///</summary>
        public long UserID { get; set; }

        ///<summary>
        ///用户昵称
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Username { get; set; }

        ///<summary>
        ///帖子标题，回帖无标题
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        ///<summary>
        ///内容
        ///</summary>
        [Column(TypeName = "text")]
        public string Content { get; set; }

        ///<summary>
        ///帖子图片
        ///</summary>
        [Column(TypeName = "nvarchar(500)")]
        public string Pics { get; set; }

        ///<summary>
        ///评论数
        ///</summary>
        public int Reviews { get; set; }

        ///<summary>
        ///点赞支持
        ///</summary>
        public int Support { get; set; }

        ///<summary>
        ///不喜欢、踩
        ///</summary>
        public int Dislike { get; set; }

        ///<summary>
        ///数据建立时间
        ///</summary>

        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

    }
}
