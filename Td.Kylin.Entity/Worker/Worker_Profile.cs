using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 服务职员附属资料
    /// </summary>
    [Table("Worker_Profile")]
    public class Worker_Profile : BaseEntity
    {
        /// <summary>
        /// 服务职员ID
        /// </summary>
        public long UserID { get; set; }
        
        /// <summary>
        /// 头像
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Photo { get; set; }
        
        /// <summary>
        /// 开始参加工作年份
        /// </summary>
        public int BeginWorkYear { get; set; }
        
        /// <summary>
        /// 春节是否回家
        /// </summary>
        public bool SpringFestivalIsBack { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        [Column(TypeName = "text")]
        public string Intro { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        
        public DateTime UpdateTime { get; set; }
    }
}
