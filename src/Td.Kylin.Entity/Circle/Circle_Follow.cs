﻿
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 圈子关注
    /// </summary>
    [Table("Circle_Follow")]
    public class Circle_Follow : BaseEntity
    {
        ///<summary>
        /// 区域圈子ID
        ///</summary>
        public long AreaForumID { get; set; }

        ///<summary>
        ///关注用户ID
        ///</summary>
        public long UserID{get;set;}

        ///<summary>
        ///最后活跃时间
        ///</summary>
        
        [Column(TypeName = "datetime")]public DateTime LastTime{get;set;}

        ///<summary>
        ///关注时间
        ///</summary>
        
        [Column(TypeName = "datetime")]public DateTime CreateTime{get;set;}
				
	}
}
