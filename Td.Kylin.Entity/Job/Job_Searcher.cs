using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 职位搜索器
    /// </summary>
    [Table("Job_Searcher",Schema ="dbo")]
    public class Job_Searcher
    {
        /// <summary>
        /// 搜索器ID
        /// </summary>
        public long SearcherID { get; set; }

        /// <summary>
        /// 所属用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 搜索器名称
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string SearcherName { get; set; }

        /// <summary>
        /// 职位类别ID
        /// </summary>
        public long CategoryID { get; set; }

        /// <summary>
        /// 职位名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string JobName { get; set; }

        /// <summary>
        /// 学历要求
        /// </summary>
        public int MinEducation { get; set; }

        /// <summary>
        /// 工作经验要求
        /// </summary>
        public int MinJobYearsType { get; set; }

        /// <summary>
        /// 工作性质（全职|兼职）
        /// </summary>
        public int JobType { get; set; }

        /// <summary>
        /// 最少月薪
        /// </summary>
        public int MinMonthly { get; set; }

        /// <summary>
        /// 最高月薪
        /// </summary>
        public int MaxMonthly { get; set; }

        /// <summary>
        /// 福利待遇（枚举：五险一金|房补等，以2的N次方定义枚举）
        /// </summary>
        public int Welfares { get; set; }

        /// <summary>
        /// 工作地点
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string WordAddress { get; set; }

        /// <summary>
        /// 招聘信息发布时间不超过的天数
        /// </summary>
        public int PublishDays { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
